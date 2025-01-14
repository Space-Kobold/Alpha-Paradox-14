// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.Wires;

/// <summary>
/// Picks a random wire on the entity's <see cref="WireComponent"/> and cuts it.
/// Runs at MapInit and removes itself afterwards.
/// </summary>
[RegisterComponent]
public sealed partial class CutWireOnMapInitComponent : Component
{
}
