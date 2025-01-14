// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Antag.Components;
using Content.Server.Objectives;
using Content.Shared.Mind;
using Content.Shared.Objectives.Systems;

namespace Content.Server.Antag;

/// <summary>
/// Adds fixed objectives to an antag made with <c>AntagObjectivesComponent</c>.
/// </summary>
public sealed class AntagObjectivesSystem : EntitySystem
{
    [Dependency] private readonly SharedMindSystem _mind = default!;

    public override void Initialize()
    {
        base.Initialize();

        SubscribeLocalEvent<AntagObjectivesComponent, AfterAntagEntitySelectedEvent>(OnAntagSelected);
    }

    private void OnAntagSelected(Entity<AntagObjectivesComponent> ent, ref AfterAntagEntitySelectedEvent args)
    {
        if (!_mind.TryGetMind(args.Session, out var mindId, out var mind))
        {
            Log.Error($"Antag {ToPrettyString(args.EntityUid):player} was selected by {ToPrettyString(ent):rule} but had no mind attached!");
            return;
        }

        foreach (var id in ent.Comp.Objectives)
        {
            _mind.TryAddObjective(mindId, mind, id);
        }
    }
}
