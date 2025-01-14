// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;

namespace Content.Shared.Silicons.StationAi;

/// <summary>
/// Indicates this entity is currently held inside of a station AI core.
/// </summary>
[RegisterComponent, NetworkedComponent]
public sealed partial class StationAiHeldComponent : Component;
