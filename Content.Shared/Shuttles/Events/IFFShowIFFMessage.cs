// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Serialization;

namespace Content.Shared.Shuttles.Events;

/// <summary>
/// Raised on a client IFF console when it wishes to show IFF.
/// </summary>
[Serializable, NetSerializable]
public sealed class IFFShowIFFMessage : BoundUserInterfaceMessage
{
    public bool Show;
}
