// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using System.Numerics;
using Content.Client.UserInterface.Controls;
using Content.Shared.Preferences;
using Content.Shared.Preferences.Loadouts;
using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface.XAML;
using Robust.Shared.Player;
using Robust.Shared.Prototypes;
using Robust.Shared.Random;

namespace Content.Client.Lobby.UI.Loadouts;

[GenerateTypedNameReferences]
public sealed partial class LoadoutWindow : FancyWindow
{
    public event Action<ProtoId<LoadoutGroupPrototype>, ProtoId<LoadoutPrototype>>? OnLoadoutPressed;
    public event Action<ProtoId<LoadoutGroupPrototype>, ProtoId<LoadoutPrototype>>? OnLoadoutUnpressed;

    private List<LoadoutGroupContainer> _groups = new();

    public HumanoidCharacterProfile Profile;

    public LoadoutWindow(HumanoidCharacterProfile profile, RoleLoadout loadout, RoleLoadoutPrototype proto, ICommonSession session, IDependencyCollection collection)
    {
        RobustXamlLoader.Load(this);
        Profile = profile;
        var protoManager = collection.Resolve<IPrototypeManager>();

        // Hide if no groups
        if (proto.Groups.Count == 0)
        {
            LoadoutGroupsContainer.Visible = false;
            SetSize = Vector2.Zero;
        }
        else
        {
            foreach (var group in proto.Groups)
            {
                if (!protoManager.TryIndex(group, out var groupProto))
                    continue;

                if (groupProto.Hidden)
                    continue;

                var container = new LoadoutGroupContainer(profile, loadout, protoManager.Index(group), session, collection);
                LoadoutGroupsContainer.AddTab(container, Loc.GetString(groupProto.Name));
                _groups.Add(container);

                container.OnLoadoutPressed += args =>
                {
                    OnLoadoutPressed?.Invoke(group, args);
                };

                container.OnLoadoutUnpressed += args =>
                {
                    OnLoadoutUnpressed?.Invoke(group, args);
                };
            }
        }
    }

    public void RefreshLoadouts(RoleLoadout loadout, ICommonSession session, IDependencyCollection collection)
    {
        foreach (var group in _groups)
        {
            group.RefreshLoadouts(Profile, loadout, session, collection);
        }
    }
}
