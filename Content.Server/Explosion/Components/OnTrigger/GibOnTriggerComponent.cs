// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.Explosion.Components;

/// <summary>
/// Gibs on trigger, self explanatory.
/// Also in case of an implant using this, gibs the implant user instead.
/// </summary>
[RegisterComponent]
public sealed partial class GibOnTriggerComponent : Component
{
    /// <summary>
    /// Should gibbing also delete the owners items?
    /// </summary>
    [ViewVariables(VVAccess.ReadWrite)]
    [DataField("deleteItems")]
    public bool DeleteItems = false;
}
