// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Xenoarchaeology.XenoArtifacts.Effects.Systems;
using Robust.Shared.Prototypes;

namespace Content.Server.Xenoarchaeology.XenoArtifacts.Effects.Components;

/// <summary>
///     When activated artifact will spawn an pair portals. First - right in artifact, Second - at random point of station.
/// </summary>
[RegisterComponent, Access(typeof(PortalArtifactSystem))]
public sealed partial class PortalArtifactComponent : Component
{
    [DataField]
    public EntProtoId PortalProto = "PortalArtifact";
}
