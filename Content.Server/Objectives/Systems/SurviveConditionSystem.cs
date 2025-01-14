// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Objectives.Components;
using Content.Shared.Objectives.Components;
using Content.Shared.Mind;

namespace Content.Server.Objectives.Systems;

/// <summary>
/// Handles progress for the survive objective condition.
/// </summary>
public sealed class SurviveConditionSystem : EntitySystem
{
    [Dependency] private readonly SharedMindSystem _mind = default!;

    public override void Initialize()
    {
        base.Initialize();

        SubscribeLocalEvent<SurviveConditionComponent, ObjectiveGetProgressEvent>(OnGetProgress);
    }

    private void OnGetProgress(EntityUid uid, SurviveConditionComponent comp, ref ObjectiveGetProgressEvent args)
    {
        args.Progress = _mind.IsCharacterDeadIc(args.Mind) ? 0f : 1f;
    }
}
