// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Xenoarchaeology.XenoArtifacts.Effects.Components;
using Content.Server.Xenoarchaeology.XenoArtifacts.Events;
using Content.Shared.Popups;
using Robust.Shared.Player;
using Robust.Shared.Random;

namespace Content.Server.Xenoarchaeology.XenoArtifacts.Effects.Systems;

public sealed class RandomTeleportArtifactSystem : EntitySystem
{
    [Dependency] private readonly IRobustRandom _random = default!;
    [Dependency] private readonly SharedPopupSystem _popup = default!;
    [Dependency] private readonly SharedTransformSystem _xform = default!;

    /// <inheritdoc/>
    public override void Initialize()
    {
        SubscribeLocalEvent<RandomTeleportArtifactComponent, ArtifactActivatedEvent>(OnActivate);
    }

    private void OnActivate(EntityUid uid, RandomTeleportArtifactComponent component, ArtifactActivatedEvent args)
    {
        var xform = Transform(uid);
        _popup.PopupCoordinates(Loc.GetString("blink-artifact-popup"), xform.Coordinates, PopupType.Medium);

        _xform.SetCoordinates(uid, xform, xform.Coordinates.Offset(_random.NextVector2(component.MinRange, component.MaxRange)));
    }
}
