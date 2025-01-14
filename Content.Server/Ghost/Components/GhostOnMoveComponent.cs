// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.Ghost.Components
{
    [RegisterComponent]
    public sealed partial class GhostOnMoveComponent : Component
    {
        [DataField("canReturn")] public bool CanReturn { get; set; } = true;

        [DataField("mustBeDead")]
        public bool MustBeDead = false;
    }
}
