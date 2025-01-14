// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Damage.Systems;
using Robust.Shared.GameStates;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom;

namespace Content.Shared.Damage.Components;

[RegisterComponent, NetworkedComponent]
[AutoGenerateComponentState, AutoGenerateComponentPause]
[Access(typeof(DamageOnHoldingSystem))]
public sealed partial class DamageOnHoldingComponent : Component
{
    [DataField("enabled"), ViewVariables(VVAccess.ReadWrite)]
    [AutoNetworkedField]
    public bool Enabled = true;

    /// <summary>
    /// Damage per interval dealt to entity holding the entity with this component
    /// </summary>
    [DataField("damage"), ViewVariables(VVAccess.ReadWrite)]
    public DamageSpecifier Damage = new();
    // TODO: make it networked

    /// <summary>
    /// Delay between damage events in seconds
    /// </summary>
    [DataField("interval"), ViewVariables(VVAccess.ReadWrite)]
    [AutoNetworkedField]
    public float Interval = 1f;

    [DataField("nextDamage", customTypeSerializer: typeof(TimeOffsetSerializer)), ViewVariables(VVAccess.ReadWrite)]
    [AutoNetworkedField]
    [AutoPausedField]
    public TimeSpan NextDamage = TimeSpan.Zero;
}
