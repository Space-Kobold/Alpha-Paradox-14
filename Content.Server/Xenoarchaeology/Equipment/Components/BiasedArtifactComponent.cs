// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.Xenoarchaeology.Equipment.Components;

/// <summary>
/// This is used for artifacts that are biased to move
/// in a particular direction via the <see cref="TraversalDistorterComponent"/>
/// </summary>
[RegisterComponent]
public sealed partial class BiasedArtifactComponent : Component
{
    [ViewVariables]
    public EntityUid Provider;
}
