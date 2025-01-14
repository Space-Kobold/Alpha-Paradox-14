// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Serialization;

namespace Content.Shared.Chemistry
{
    [Serializable, NetSerializable]
    public enum SolutionContainerVisuals : byte
    {
        Color,
        FillFraction,
        BaseOverride,
        SolutionName
    }

    public enum SolutionContainerLayers : byte
    {
        Fill,
        Base,
        Overlay
    }
}
