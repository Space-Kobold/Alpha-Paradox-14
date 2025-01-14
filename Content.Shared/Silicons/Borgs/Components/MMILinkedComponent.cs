// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;

namespace Content.Shared.Silicons.Borgs.Components;

/// <summary>
/// This is used for an entity that is linked to an MMI.
/// Mostly for receiving events.
/// </summary>
[RegisterComponent, NetworkedComponent, Access(typeof(SharedBorgSystem))]
[AutoGenerateComponentState]
public sealed partial class MMILinkedComponent : Component
{
    /// <summary>
    /// The MMI this entity is linked to.
    /// </summary>
    [DataField("linkedMMI"), AutoNetworkedField]
    public EntityUid? LinkedMMI;
}
