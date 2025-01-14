// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Mobs;

namespace Content.Server.NPC.Queries.Considerations;

/// <summary>
/// Goes linearly from 1f to 0f, with 0 damage returning 1f and <see cref=TargetState> damage returning 0f
/// </summary>
public sealed partial class TargetHealthCon : UtilityConsideration
{

    /// <summary>
    /// Which MobState the consideration returns 0f at, defaults to choosing earliest incapacitating MobState
    /// </summary>
    [DataField("targetState")]
    public MobState TargetState = MobState.Invalid;
}
