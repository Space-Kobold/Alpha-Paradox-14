// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Serialization;

namespace Content.Shared.Mousetrap;

[Serializable, NetSerializable]
public enum MousetrapVisuals : byte
{
    Visual,
    Armed,
    Unarmed
}
