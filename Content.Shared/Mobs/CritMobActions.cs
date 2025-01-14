// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Actions;

namespace Content.Shared.Mobs;

/// <summary>
///     Only applies to mobs in crit capable of ghosting/succumbing
/// </summary>
public sealed partial class CritSuccumbEvent : InstantActionEvent
{
}

/// <summary>
///     Only applies/has functionality to mobs in crit that have <see cref="DeathgaspComponent"/>
/// </summary>
public sealed partial class CritFakeDeathEvent : InstantActionEvent
{
}

/// <summary>
///     Only applies to mobs capable of speaking, as a last resort in crit
/// </summary>
public sealed partial class CritLastWordsEvent : InstantActionEvent
{
}
