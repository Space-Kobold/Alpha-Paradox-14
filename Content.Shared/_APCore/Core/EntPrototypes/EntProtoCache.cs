// SPDX-FileCopyrightText: 2025 Space Kobold Games and Contributors
// SPDX-License-Identifier: MPL-2.0-no-copyleft-exception

using Robust.Shared.Prototypes;
using Robust.Shared.Utility;

namespace Content.Shared._APCore.Core.EntPrototypes;

public sealed class EntProtoCache
{
    [Dependency] private readonly IPrototypeManager _protoManager = default!;
    [Dependency] private readonly IComponentFactory _componentFactory = default!;
    [Dependency] private readonly ILogManager _logManager = default!;
    private readonly Dictionary<ReloadListenerKey, Action<EntPrototypesReloadedArgs>> _reloadListeners = new();
    private readonly Dictionary<Type, List<(int, EntityPrototype.ComponentRegistryEntry, string)>> _compTypeToProtoIndex = new();
    private readonly Dictionary<string, int> _protoIDToIndex = new();
    public readonly Action<EntPrototypesReloadedArgs>? OnEntityPrototypesReloaded;
    private readonly List<(EntityPrototype Proto, (Type type, EntityPrototype.ComponentRegistryEntry entry)[] CompTypes)> _cache = new();
    private bool _reloading = true;
    private ISawmill Log = default!;
    public void Initialize()
    {
        IoCManager.InjectDependencies(this);
        CachePrototypes();
        _protoManager.PrototypesReloaded += OnPrototypesReloaded;
        Log = _logManager.GetSawmill("EntityPrototypeCache");
    }

    private void OnPrototypesReloaded(PrototypesReloadedEventArgs args)
    {
        if (!args.Modified.Contains(typeof(EntityPrototype)))
            return;
        Log = _logManager.GetSawmill("EntityPrototypeCache"); //For some reason the server reloads prototypes before calling initialize
        Dictionary<ReloadListenerKey, (List<string> removed, List<string> modified)> listenerData = new();
        foreach (var (listener, _) in _reloadListeners)
        {
            listenerData.Add(listener, ([], []));
        }
        List<string> removedPrototypes = new();
        List<string> modifiedPrototypes = new();
        if (args.Removed != null && args.Removed.TryGetValue(typeof(SpriteSpecifier.EntityPrototype), out var removedEnts))
        {
            foreach (var id in removedEnts)
            {
                foreach (var (type,_) in _cache[_protoIDToIndex[id]].CompTypes)
                {
                    foreach (var (key, (removed,_)) in listenerData)
                    {
                        if (!key.ContainsType(type))
                            continue;
                        removed.Add(id);
                    }
                }
                removedPrototypes.Add(id);
            }
        }
        foreach (var (id, _) in args.ByType[typeof(EntityPrototype)].Modified)
        {
            foreach (var (type,_) in _cache[_protoIDToIndex[id]].CompTypes)
            {
                foreach (var (key, (_, modified)) in listenerData)
                {
                    if (!key.ContainsType(type))
                        continue;
                    modified.Add(id);
                }
            }
            modifiedPrototypes.Add(id);
        }
        //clear cached data and rebuild, we need to do this because removing entries will fuck up the lookup indices
        ClearCache();
        CachePrototypes();
        OnEntityPrototypesReloaded?.Invoke(new EntPrototypesReloadedArgs(removedPrototypes, modifiedPrototypes));
        foreach (var (key, (removed,modified) ) in listenerData)
        {
            _reloadListeners[key].Invoke(new (removed, modified));
        }
    }

    private void ClearCache()
    {
        _reloading = true;
        _cache.Clear();
        _compTypeToProtoIndex.Clear();
    }

    private void CachePrototypes()
    {
        foreach (var entProto in _protoManager.EnumeratePrototypes<EntityPrototype>())
        {
            var compTypes = new (Type, EntityPrototype.ComponentRegistryEntry)[entProto.Components.Count];
            var i = 0;
            var protoIndex = _cache.Count;
            foreach (var (_, regEntry) in entProto.Components)
            {
                var compType = regEntry.Component.GetType();
                compTypes[i] = (compType,regEntry);
                _compTypeToProtoIndex.GetOrNew(compType).Add((protoIndex, regEntry, entProto.ID));
            }
            _protoIDToIndex.Add(entProto.ID, protoIndex);
            _cache.Add((entProto, compTypes));
        }
        _reloading = false;
    }

    public void SubscribeEntityPrototypeReloaded(Action<EntPrototypesReloadedArgs> onReloaded, params Type[] componentTypes)
    {
        var key = new ReloadListenerKey(componentTypes);
        if (!_reloadListeners.TryAdd(key, onReloaded))
            _reloadListeners[key] += onReloaded;
    }

    public void SubscribeEntityPrototypeReloaded<T>(Action<EntPrototypesReloadedArgs> onReloaded)
    where T: Component, new()
    {
        SubscribeEntityPrototypeReloaded(onReloaded, typeof(T));
    }

    private bool TryIndexEntProto(string protoId, Type wantedType, out EntityPrototype data)
    {
        if (_protoIDToIndex.TryGetValue(protoId, out var protoIndex))
        {
            data = default!;
            return false;
        }
        var getProtoData = _cache[protoIndex];
        foreach (var (type, _) in getProtoData.CompTypes)
        {
            if (type != wantedType)
                continue;
            data= getProtoData.Proto;
            return true;
        }
        data = default!;
        return false;
    }

    private bool TryIndexEntProtoComp(string protoId,
        Type wantedType,
        out (EntityPrototype Proto, IComponent Comp) data)
    {
        if (_protoIDToIndex.TryGetValue(protoId,out var protoIndex))
            throw new KeyNotFoundException($"Entity prototype with ID:{protoId} could not be found");
        var getProtoData = _cache[protoIndex];
        foreach (var (type, entry) in getProtoData.CompTypes)
        {
            if (type != wantedType)
                continue;
            data = (getProtoData.Proto, _componentFactory.GetComponent(entry));
            return true;
        }
        data = default;
        return false;

    }

    private IEnumerable<(EntityPrototype Proto, EntityPrototype.ComponentRegistryEntry CompEntry)>
        EnumerateEntPrototypes(Type type)
    {
        if (_reloading)
            throw new Exception("You cannot iterate over cached entity prototypes while a (re)load is in progress!");
        if (!_compTypeToProtoIndex.TryGetValue(type, out var indices))
            yield break;
        foreach (var (index, regEntry, _) in indices)
        {
            yield return (_cache[index].Proto, regEntry);
        }
    }

    public (EntityPrototype Proto, T Comp) IndexEntProtoWithCompData<T>(string protoId)
        where T : Component, new()
    {
        if (!TryIndexEntProtoComp(protoId, typeof(T), out var data))
            throw new KeyNotFoundException($"Entity prototype with ID:{protoId} does not have component of type{typeof(T)}");
        return (data.Proto, (T)data.Comp);
    }

    public EntityPrototype IndexEntProtoWithComp<T>(string protoId)
        where T : Component, new()
    {
        if (!TryIndexEntProto(protoId, typeof(T), out var proto))
            throw new KeyNotFoundException($"Entity prototype with ID:{protoId} does not have component of type{typeof(T)}");
        return proto;
    }

    public IEnumerable<EntityPrototype> EnumerateEntPrototypesWithComp<T>()
        where T: Component, new()
    {
        foreach (var (proto, _) in EnumerateEntPrototypes(typeof(T)))
        {
            yield return proto;
        }
    }

    public IEnumerator<(EntityPrototype Proto, T Comp)> EnumerateEntPrototypesWithCompData<T>()
        where T: Component, new()
    {
        foreach (var (proto, entry) in EnumerateEntPrototypes(typeof(T)))
        {
            yield return (proto, (T)_componentFactory.GetComponent(entry));
        }
    }
    public struct EntPrototypesReloadedArgs(IReadOnlyList<string> Removed, IReadOnlyList<string> Modified);
    private readonly struct ReloadListenerKey
    {
        public readonly Type[] CompTypes;
        private readonly int _hashCode;
        public bool ContainsType(Type type)
        {
            foreach (var testType in CompTypes)
            {
                if (type == testType)
                    return true;
            }
            return false;
        }

        public ReloadListenerKey(params Type[] compTypes)
        {
            CompTypes = compTypes;
            _hashCode = 0;
            foreach (var compType in compTypes)
            {
                if (!compType.IsAssignableTo(typeof(Component)))
                    throw new Exception("tried to create a component listener from a non-component type!");
                _hashCode = HashCode.Combine(_hashCode, compType);
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;
            return _hashCode == obj.GetHashCode();
        }
        public override int GetHashCode()
        {
            return _hashCode;
        }
    }
}
