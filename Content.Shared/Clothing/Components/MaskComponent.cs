// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Clothing.EntitySystems;
using Robust.Shared.GameStates;
using Robust.Shared.Prototypes;

namespace Content.Shared.Clothing.Components;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
[Access(typeof(MaskSystem))]
public sealed partial class MaskComponent : Component
{
    [DataField, AutoNetworkedField]
    public EntProtoId ToggleAction = "ActionToggleMask";

    /// <summary>
    /// This mask can be toggled (pulled up/down)
    /// </summary>
    [DataField, AutoNetworkedField]
    public EntityUid? ToggleActionEntity;

    [DataField, AutoNetworkedField]
    public bool IsToggled;

    [DataField, AutoNetworkedField]
    public string EquippedPrefix = "toggled";

    /// <summary>
    /// When <see langword="true"/> will function normally, otherwise will not react to events
    /// </summary>
    [DataField("enabled"), AutoNetworkedField]
    public bool IsEnabled = true;

    /// <summary>
    /// When <see langword="true"/> will disable <see cref="IsEnabled"/> when folded
    /// </summary>
    [DataField, AutoNetworkedField]
    public bool DisableOnFolded;
}
