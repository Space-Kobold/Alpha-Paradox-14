// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Serialization;

namespace Content.Shared.Shuttles.BUIStates;

/// <summary>
/// Wrapper around <see cref="NavInterfaceState"/>
/// </summary>
[Serializable, NetSerializable]
public sealed class NavBoundUserInterfaceState : BoundUserInterfaceState
{
    public NavInterfaceState State;

    public NavBoundUserInterfaceState(NavInterfaceState state)
    {
        State = state;
    }
}
