// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using System.Numerics;
using Robust.Shared.GameStates;

namespace Content.Shared.Medical.Cryogenics;

[RegisterComponent]
[NetworkedComponent]
public sealed partial class InsideCryoPodComponent: Component
{
    [ViewVariables]
    [DataField("previousOffset")]
    public Vector2 PreviousOffset { get; set; } = new(0, 0);
}
