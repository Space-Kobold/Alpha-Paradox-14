// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;

namespace Content.Shared.Electrocution;

/// <summary>
/// Allow an entity to see the Electrocution HUD showing electrocuted doors.
/// </summary>
[RegisterComponent, NetworkedComponent]
public sealed partial class ShowElectrocutionHUDComponent : Component;
