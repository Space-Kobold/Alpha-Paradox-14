// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Inventory;

namespace Content.Server.Storage.Components;

/// <summary>
/// Applies an ongoing pickup area around the attached entity.
/// </summary>
[RegisterComponent, AutoGenerateComponentPause]
public sealed partial class MagnetPickupComponent : Component
{
    [ViewVariables(VVAccess.ReadWrite), DataField("nextScan")]
    [AutoPausedField]
    public TimeSpan NextScan = TimeSpan.Zero;

    /// <summary>
    /// What container slot the magnet needs to be in to work.
    /// </summary>
    [ViewVariables(VVAccess.ReadWrite), DataField("slotFlags")]
    public SlotFlags SlotFlags = SlotFlags.BELT;

    [ViewVariables(VVAccess.ReadWrite), DataField("range")]
    public float Range = 1f;
}
