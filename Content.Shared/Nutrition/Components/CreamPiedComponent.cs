// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Nutrition.EntitySystems;
using Robust.Shared.Serialization;

namespace Content.Shared.Nutrition.Components
{
    [Access(typeof(SharedCreamPieSystem))]
    [RegisterComponent]
    public sealed partial class CreamPiedComponent : Component
    {
        [ViewVariables]
        public bool CreamPied { get; set; } = false;
    }

    [Serializable, NetSerializable]
    public enum CreamPiedVisuals
    {
        Creamed,
    }
}
