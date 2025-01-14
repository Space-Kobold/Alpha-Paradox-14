// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;

namespace Content.Shared.Weapons.Misc;

/// <summary>
/// Added to entities tethered by a tethergun.
/// </summary>
[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
public sealed partial class TetheredComponent : Component
{
    [DataField("tetherer"), AutoNetworkedField]
    public EntityUid Tetherer;

    [ViewVariables(VVAccess.ReadWrite), DataField("originalAngularDamping"), AutoNetworkedField]
    public float OriginalAngularDamping;
}
