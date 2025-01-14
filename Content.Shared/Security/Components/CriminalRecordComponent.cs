// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.StatusIcon;
using Robust.Shared.GameStates;
using Robust.Shared.Prototypes;

namespace Content.Shared.Security.Components;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
public sealed partial class CriminalRecordComponent : Component
{
    /// <summary>
    ///     The icon that should be displayed based on the criminal status of the entity.
    /// </summary>
    [DataField, AutoNetworkedField]
    public ProtoId<SecurityIconPrototype> StatusIcon = "SecurityIconWanted";
}
