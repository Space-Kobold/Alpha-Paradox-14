// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Construction.Prototypes;
using Robust.Shared.GameObjects;
using Robust.Shared.ViewVariables;

namespace Content.Client.Construction
{
    [RegisterComponent]
    public sealed partial class ConstructionGhostComponent : Component
    {
        [ViewVariables] public ConstructionPrototype? Prototype { get; set; }
    }
}
