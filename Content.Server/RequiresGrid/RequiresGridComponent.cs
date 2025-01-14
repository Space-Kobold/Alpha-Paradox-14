// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.RequiresGrid;

/// <summary>
/// Destroys an entity when they no longer are part of a Grid
/// </summary>
[RegisterComponent]
[Access(typeof(RequiresGridSystem))]
public sealed partial class RequiresGridComponent : Component
{

}
