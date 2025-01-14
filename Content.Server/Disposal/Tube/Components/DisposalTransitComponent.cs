// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.Disposal.Tube.Components
{
    // TODO: Different types of tubes eject in random direction with no exit point
    [RegisterComponent]
    [Access(typeof(DisposalTubeSystem))]
    [Virtual]
    public partial class DisposalTransitComponent : Component
    {
    }
}
