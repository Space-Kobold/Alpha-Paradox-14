// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Body.Components;
using Robust.Shared.Serialization;

namespace Content.Shared.Body.Part
{
    /// <summary>
    ///     Defines the symmetry of a <see cref="BodyComponent"/>.
    /// </summary>
    [Serializable, NetSerializable]
    public enum BodyPartSymmetry
    {
        None = 0,
        Left,
        Right
    }
}
