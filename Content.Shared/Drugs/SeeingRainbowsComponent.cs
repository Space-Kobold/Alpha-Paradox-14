// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;

namespace Content.Shared.Drugs;

/// <summary>
///     Exists for use as a status effect. Adds a shader to the client that scales with the effect duration.
/// </summary>
[RegisterComponent, NetworkedComponent]
public sealed partial class SeeingRainbowsComponent : Component { }
