// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Dataset;
using Content.Shared.Humanoid.Prototypes;
using Robust.Shared.Prototypes;
using Robust.Shared.Random;

namespace Content.Shared.Humanoid
{
    // You need to update profile, profile editor, maybe voices and names if you want to expand this further.
    public enum Sex : byte
    {
        Male,
        Female,
        Unsexed,
    }

    /// <summary>
    ///     Raised when entity has changed their sex.
    ///     This doesn't handle gender changes.
    /// </summary>
    public record struct SexChangedEvent(Sex OldSex, Sex NewSex);
}
