// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.PowerCell;
using Robust.Shared.GameStates;

namespace Content.Shared.UserInterface;

/// <summary>
/// Specifies that the attached entity requires <see cref="PowerCellDrawComponent"/> power.
/// </summary>
[RegisterComponent, NetworkedComponent]
public sealed partial class ActivatableUIRequiresPowerCellComponent : Component
{

}
