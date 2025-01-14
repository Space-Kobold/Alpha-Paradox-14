// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Prototypes;

namespace Content.Server.Antag.Mimic;

/// <summary>
/// Replaces the relevant entities with mobs when the game rule is started.
/// </summary>
[RegisterComponent]
public sealed partial class MobReplacementRuleComponent : Component
{
    // If you want more components use generics, using a whitelist would probably kill the server iterating every single entity.

    [DataField]
    public EntProtoId Proto = "MobMimic";

    /// <summary>
    /// Chance per-entity.
    /// </summary>
    [DataField]
    public float Chance = 0.004f;
}
