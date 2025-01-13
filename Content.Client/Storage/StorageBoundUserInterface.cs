// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Client.Storage.Systems;
using Content.Shared.Storage;
using JetBrains.Annotations;

namespace Content.Client.Storage;

[UsedImplicitly]
public sealed class StorageBoundUserInterface : BoundUserInterface
{
    [Dependency] private readonly IEntityManager _entManager = default!;

    private readonly StorageSystem _storage;

    [Obsolete] public override bool DeferredClose => false;

    public StorageBoundUserInterface(EntityUid owner, Enum uiKey) : base(owner, uiKey)
    {
        IoCManager.InjectDependencies(this);
        _storage = _entManager.System<StorageSystem>();
    }

    protected override void Open()
    {
        base.Open();

        if (_entManager.TryGetComponent<StorageComponent>(Owner, out var comp))
            _storage.OpenStorageWindow((Owner, comp));
    }

    protected override void Dispose(bool disposing)
    {
        base.Dispose(disposing);
        if (!disposing)
            return;

        _storage.CloseStorageWindow(Owner);
    }
}

