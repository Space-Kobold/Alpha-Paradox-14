// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Shuttles.UI.MapObjects;

/// <summary>
/// Abstract map object representing a grid, beacon etc for use on the map screen.
/// </summary>
public interface IMapObject
{
    string Name { get; }

    /// <summary>
    /// Should we hide the button from being shown (AKA just draw it).
    /// </summary>
    bool HideButton { get; }
}
