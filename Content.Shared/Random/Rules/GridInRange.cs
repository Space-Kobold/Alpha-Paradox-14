// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using System.Numerics;
using Robust.Shared.Map;

namespace Content.Shared.Random.Rules;

/// <summary>
/// Returns true if on a grid or in range of one.
/// </summary>
public sealed partial class GridInRangeRule : RulesRule
{
    [DataField]
    public float Range = 10f;

    public override bool Check(EntityManager entManager, EntityUid uid)
    {
        if (!entManager.TryGetComponent(uid, out TransformComponent? xform))
        {
            return false;
        }

        if (xform.GridUid != null)
        {
            return !Inverted;
        }

        var transform = entManager.System<SharedTransformSystem>();
        var mapManager = IoCManager.Resolve<IMapManager>();

        var worldPos = transform.GetWorldPosition(xform);
        var gridRange = new Vector2(Range, Range);

        foreach (var _ in mapManager.FindGridsIntersecting(xform.MapID, new Box2(worldPos - gridRange, worldPos + gridRange)))
        {
            return !Inverted;
        }

        return Inverted;
    }
}
