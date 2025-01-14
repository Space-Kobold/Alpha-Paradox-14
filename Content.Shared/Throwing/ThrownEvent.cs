// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using JetBrains.Annotations;

namespace Content.Shared.Throwing;

/// <summary>
///     Raised on thrown entity.
/// </summary>
[PublicAPI]
[ByRefEvent]
public readonly record struct ThrownEvent(EntityUid? User, EntityUid Thrown);
