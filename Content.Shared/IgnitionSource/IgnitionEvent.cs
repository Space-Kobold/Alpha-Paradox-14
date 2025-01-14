// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.IgnitionSource;

/// <summary>
///     Raised in order to toggle the ignitionSourceComponent on an entity on or off
/// </summary>
[ByRefEvent]
public readonly record struct IgnitionEvent(bool Ignite = false);
