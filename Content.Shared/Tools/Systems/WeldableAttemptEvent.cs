// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Tools.Systems;

/// <summary>
///     Checks that entity can be weld/unweld.
///     Raised twice: before do_after and after to check that entity still valid.
/// </summary>
public sealed class WeldableAttemptEvent : CancellableEntityEventArgs
{
    public readonly EntityUid User;
    public readonly EntityUid Tool;

    public WeldableAttemptEvent(EntityUid user, EntityUid tool)
    {
        User = user;
        Tool = tool;
    }
}