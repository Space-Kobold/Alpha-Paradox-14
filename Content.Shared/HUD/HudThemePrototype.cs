// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Prototypes;

namespace Content.Shared.HUD
{
    [Prototype("hudTheme")]
    public sealed partial class HudThemePrototype : IPrototype, IComparable<HudThemePrototype>
    {
        [DataField("name", required: true)]
        public string Name { get; private set; } = string.Empty;

        [IdDataField]
        public string ID { get; private set; } = string.Empty;

        [DataField("path", required: true)]
        public string Path { get; private set; } = string.Empty;

        /// <summary>
        /// An order for the themes to be displayed in the UI
        /// </summary>
        [DataField]
        public int Order = 0;

        public int CompareTo(HudThemePrototype? other)
        {
            return Order.CompareTo(other?.Order);
        }
    }
}
