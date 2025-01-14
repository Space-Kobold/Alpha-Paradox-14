// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Alert;
using Robust.Shared.GameStates;
using Robust.Shared.Prototypes;

namespace Content.Shared.Clothing;

[RegisterComponent, NetworkedComponent]
[Access(typeof(SharedMagbootsSystem))]
public sealed partial class MagbootsComponent : Component
{
    [DataField]
    public ProtoId<AlertPrototype> MagbootsAlert = "Magboots";

    /// <summary>
    /// If true, the user must be standing on a grid or planet map to experience the weightlessness-canceling effect
    /// </summary>
    [DataField]
    public bool RequiresGrid = true;

    /// <summary>
    /// Slot the clothing has to be worn in to work.
    /// </summary>
    [DataField]
    public string Slot = "shoes";
}
