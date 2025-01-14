// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Xenoarchaeology.XenoArtifacts.Triggers.Components;
using Content.Shared.Throwing;

namespace Content.Server.Xenoarchaeology.XenoArtifacts.Triggers.Systems;

public sealed class ArtifactLandSystem : EntitySystem
{
    [Dependency] private readonly ArtifactSystem _artifact = default!;

    public override void Initialize()
    {
        base.Initialize();

        SubscribeLocalEvent<ArtifactLandTriggerComponent, LandEvent>(OnLand);
    }

    private void OnLand(EntityUid uid, ArtifactLandTriggerComponent component, ref LandEvent args)
    {
        _artifact.TryActivateArtifact(uid, args.User);
    }
}
