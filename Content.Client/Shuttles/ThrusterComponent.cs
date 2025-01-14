// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;

namespace Content.Client.Shuttles;

/// <summary>
/// A component that emits a visible exhaust plume if the entity is an active thruster.
/// Managed by <see cref="ThrusterSystem"/>
/// </summary>
[RegisterComponent, NetworkedComponent, Access(typeof(ThrusterSystem))]
public sealed partial class ThrusterComponent : Component
{
}
