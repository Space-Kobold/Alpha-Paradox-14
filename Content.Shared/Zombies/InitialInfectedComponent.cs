// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.StatusIcon;
using Robust.Shared.GameStates;
using Robust.Shared.Prototypes;

namespace Content.Shared.Zombies;

[RegisterComponent, NetworkedComponent]
public sealed partial class InitialInfectedComponent : Component
{
    [DataField]
    public ProtoId<FactionIconPrototype> StatusIcon = "InitialInfectedFaction";
}
