// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Kitchen.Components;
using Content.Server.Xenoarchaeology.XenoArtifacts.Triggers.Components;

namespace Content.Server.Xenoarchaeology.XenoArtifacts.Triggers.Systems;

public sealed class ArtifactMicrowaveTriggerSystem : EntitySystem
{
    [Dependency] private readonly ArtifactSystem _artifact = default!;

    /// <inheritdoc/>
    public override void Initialize()
    {
        SubscribeLocalEvent<ArtifactMicrowaveTriggerComponent, BeingMicrowavedEvent>(OnMicrowaved);
    }

    private void OnMicrowaved(EntityUid uid, ArtifactMicrowaveTriggerComponent component, BeingMicrowavedEvent args)
    {
        _artifact.TryActivateArtifact(uid);
    }
}
