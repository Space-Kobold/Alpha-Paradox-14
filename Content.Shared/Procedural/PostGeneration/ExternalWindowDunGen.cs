// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Procedural.PostGeneration;

/// <summary>
/// If external areas are found will try to generate windows.
/// </summary>
/// <remarks>
/// Dungeon data keys are:
/// - EntranceFlank
/// - FallbackTile
/// </remarks>
public sealed partial class ExternalWindowDunGen : IDunGenLayer;
