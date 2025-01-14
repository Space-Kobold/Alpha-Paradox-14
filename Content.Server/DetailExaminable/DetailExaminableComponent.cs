// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.DetailExaminable
{
    [RegisterComponent]
    public sealed partial class DetailExaminableComponent : Component
    {
        [DataField("content", required: true)] [ViewVariables(VVAccess.ReadWrite)]
        public string Content = "";
    }
}
