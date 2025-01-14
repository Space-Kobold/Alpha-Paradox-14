// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Construction.Components;
using Robust.Shared.Containers;
using Robust.Shared.Prototypes;

namespace Content.Server.Construction.Components;

[RegisterComponent]
public sealed partial class MachineComponent : Component
{
    [DataField]
    public EntProtoId<MachineBoardComponent>? Board { get; private set; }

    [ViewVariables]
    public Container BoardContainer = default!;
    [ViewVariables]
    public Container PartContainer = default!;
}
