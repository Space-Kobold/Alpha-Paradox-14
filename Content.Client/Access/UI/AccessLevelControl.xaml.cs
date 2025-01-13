// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using System.Linq;
using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface;
using Robust.Client.UserInterface.Controls;
using Robust.Client.UserInterface.XAML;
using Robust.Shared.Prototypes;
using Content.Shared.Access;
using Content.Shared.Access.Systems;

namespace Content.Client.Access.UI;

[GenerateTypedNameReferences]
public sealed partial class AccessLevelControl : GridContainer
{
    [Dependency] private readonly ILogManager _logManager = default!;

    private ISawmill _sawmill = default!;

    public readonly Dictionary<ProtoId<AccessLevelPrototype>, Button> ButtonsList = new();

    public AccessLevelControl()
    {
        RobustXamlLoader.Load(this);
        IoCManager.InjectDependencies(this);

        _sawmill = _logManager.GetSawmill("accesslevelcontrol");
    }

    public void Populate(List<ProtoId<AccessLevelPrototype>> accessLevels, IPrototypeManager prototypeManager)
    {
        foreach (var access in accessLevels)
        {
            if (!prototypeManager.TryIndex(access, out var accessLevel))
            {
                _sawmill.Error($"Unable to find accesslevel for {access}");
                continue;
            }

            var newButton = new Button
            {
                Text = accessLevel.GetAccessLevelName(),
                ToggleMode = true,
            };
            AddChild(newButton);
            ButtonsList.Add(accessLevel.ID, newButton);
        }
    }

    public void UpdateState(
        List<ProtoId<AccessLevelPrototype>> pressedList,
        List<ProtoId<AccessLevelPrototype>>? enabledList = null)
    {
        foreach (var (accessName, button) in ButtonsList)
        {
            button.Pressed = pressedList.Contains(accessName);
            button.Disabled = !(enabledList?.Contains(accessName) ?? true);
        }
    }
}
