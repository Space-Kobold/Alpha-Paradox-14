// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Damage.Systems;
using Robust.Shared.GameStates;

namespace Content.Shared.Damage.Components;

/// <summary>
/// Applies stamina damage when embeds in an entity.
/// </summary>
[RegisterComponent]
[NetworkedComponent]
[AutoGenerateComponentState]
[Access(typeof(StaminaSystem))]
public sealed partial class StaminaDamageOnEmbedComponent : Component
{
    [ViewVariables(VVAccess.ReadWrite), DataField, AutoNetworkedField]
    public float Damage = 10f;
}
