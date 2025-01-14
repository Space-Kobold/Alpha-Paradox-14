// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Utility;

namespace Content.Shared.Damage.Events;

[ByRefEvent]
public readonly record struct DamageExamineEvent(FormattedMessage Message, EntityUid User);
