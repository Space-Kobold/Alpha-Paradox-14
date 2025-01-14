// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Prototypes;

namespace Content.Server.Zombies;

/// <summary>
/// This is used for a zombie that cannot be cured by any methods. Gives a succumb to zombie infection action.
/// </summary>
[RegisterComponent]
public sealed partial class IncurableZombieComponent : Component
{
    [DataField]
    public EntProtoId ZombifySelfActionPrototype = "ActionTurnUndead";

    [DataField]
    public EntityUid? Action;
}
