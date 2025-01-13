// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Client.Kudzu
{
    [RegisterComponent]
    public sealed partial class KudzuVisualsComponent : Component
    {
        [DataField("layer")]
        public int Layer { get; private set; } = 0;
    }

}
