// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Whitelist;
using Robust.Shared.GameStates;

namespace Content.Shared.Damage.Components;

[NetworkedComponent, RegisterComponent]
public sealed partial class DamageContactsComponent : Component
{
    /// <summary>
    /// The damage done each second to those touching this entity
    /// </summary>
    [DataField("damage", required: true)]
    public DamageSpecifier Damage = new();

    /// <summary>
    /// Entities that aren't damaged by this entity
    /// </summary>
    [DataField("ignoreWhitelist")]
    public EntityWhitelist? IgnoreWhitelist;
}
