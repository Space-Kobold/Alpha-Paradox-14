// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Shuttles.Systems;

namespace Content.Server.Shuttles.Components;

/// <summary>
/// Prevents FTL from occuring around this entity.
/// </summary>
[RegisterComponent, Access(typeof(SharedShuttleSystem))]
public sealed partial class FTLExclusionComponent : Component
{
    [DataField]
    public bool Enabled = true;

    [DataField(required: true)]
    public float Range = 32f;
}
