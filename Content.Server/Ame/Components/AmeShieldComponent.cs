// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Ame.EntitySystems;
using Content.Shared.Ame.Components;

namespace Content.Server.Ame.Components;

/// <summary>
/// The component used to make an entity part of the bulk machinery of an AntiMatter Engine.
/// Connects to adjacent entities with this component or <see cref="AmeControllerComponent"/> to make an AME.
/// </summary>
[Access(typeof(AmeShieldingSystem), typeof(AmeNodeGroup))]
[RegisterComponent]
public sealed partial class AmeShieldComponent : SharedAmeShieldComponent
{
    /// <summary>
    /// Whether or not this AME shield counts as a core for the AME or not.
    /// </summary>
    [ViewVariables]
    public bool IsCore = false;

    /// <summary>
    /// The current integrity of the AME shield.
    /// </summary>
    [DataField("integrity")]
    [ViewVariables]
    public int CoreIntegrity = 100;
}
