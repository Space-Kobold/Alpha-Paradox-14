// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Random.Rules;

/// <summary>
/// Returns true if griduid and mapuid match (AKA on 'planet').
/// </summary>
public sealed partial class OnMapGridRule : RulesRule
{
    public override bool Check(EntityManager entManager, EntityUid uid)
    {
        if (!entManager.TryGetComponent(uid, out TransformComponent? xform) ||
            xform.GridUid != xform.MapUid ||
            xform.MapUid == null)
        {
            return Inverted;
        }

        return !Inverted;
    }
}
