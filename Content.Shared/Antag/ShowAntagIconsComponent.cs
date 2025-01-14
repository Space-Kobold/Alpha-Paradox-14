// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;

namespace Content.Shared.Antag;

/// <summary>
/// Determines whether Someone can see antags icons
/// </summary>
[RegisterComponent, NetworkedComponent]
public sealed partial class ShowAntagIconsComponent: Component;
