// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.Salvage.Magnet;

/// <summary>
/// Indicates the entity is a salvage target for tracking.
/// </summary>
[RegisterComponent]
public sealed partial class SalvageMagnetTargetComponent : Component
{
    /// <summary>
    /// Entity that spawned us.
    /// </summary>
    [DataField]
    public EntityUid DataTarget;
}
