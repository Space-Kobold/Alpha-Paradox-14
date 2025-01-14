// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Construction;

public interface IGraphTransform
{
    public void Transform(EntityUid oldUid, EntityUid newUid, EntityUid? userUid, GraphTransformArgs args);
}

public readonly struct GraphTransformArgs
{
    public readonly IEntityManager EntityManager;

    public GraphTransformArgs(IEntityManager entityManager)
    {
        EntityManager = entityManager;
    }
}
