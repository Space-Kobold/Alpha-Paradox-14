// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;

namespace Content.Shared.Chemistry.Components;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState(true)]
public sealed partial class PillComponent : Component
{
    /// <summary>
    /// The pill id. Used for networking & serializing pill visuals.
    /// </summary>
    [AutoNetworkedField]
    [DataField("pillType")]
    [ViewVariables(VVAccess.ReadWrite)]
    public uint PillType;
}
