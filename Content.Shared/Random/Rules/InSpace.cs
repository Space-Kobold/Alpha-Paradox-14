// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Random.Rules;

/// <summary>
/// Returns true if the attached entity is in space.
/// </summary>
public sealed partial class InSpaceRule : RulesRule
{
    public override bool Check(EntityManager entManager, EntityUid uid)
    {
        if (!entManager.TryGetComponent(uid, out TransformComponent? xform) ||
            xform.GridUid != null)
        {
            return Inverted;
        }

        return !Inverted;
    }
}
