// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Construction;
using Content.Shared.Damage;
using Content.Shared.Damage.Systems;

namespace Content.Server.Construction.Completions;

/// <summary>
/// Damage the entity on step completion.
/// </summary>
[DataDefinition]
public sealed partial class DamageEntity : IGraphAction
{
    /// <summary>
    /// Damage to deal to the entity.
    /// </summary>
    [DataField]
    public DamageSpecifier Damage;

    public void PerformAction(EntityUid uid, EntityUid? userUid, IEntityManager entityManager)
    {
        entityManager.System<DamageableSystem>().TryChangeDamage(uid, Damage, origin: userUid);
    }
}
