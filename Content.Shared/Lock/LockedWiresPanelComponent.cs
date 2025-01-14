// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Wires;
using Robust.Shared.GameStates;

namespace Content.Shared.Lock;

/// <summary>
/// This is used for a <see cref="WiresPanelComponent"/> that cannot be opened while locked.
/// </summary>
[RegisterComponent, NetworkedComponent, Access(typeof(LockSystem))]
public sealed partial class LockedWiresPanelComponent : Component
{

}
