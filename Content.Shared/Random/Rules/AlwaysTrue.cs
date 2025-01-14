// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Random.Rules;

/// <summary>
/// Always returns true. Used for fallbacks.
/// </summary>
public sealed partial class AlwaysTrueRule : RulesRule
{
    public override bool Check(EntityManager entManager, EntityUid uid)
    {
        return !Inverted;
    }
}
