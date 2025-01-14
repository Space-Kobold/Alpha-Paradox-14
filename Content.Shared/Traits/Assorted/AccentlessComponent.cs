// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;
using Robust.Shared.Prototypes;

namespace Content.Shared.Traits.Assorted;

/// <summary>
/// This is used for the accentless trait
/// </summary>
[RegisterComponent, NetworkedComponent]
public sealed partial class AccentlessComponent : Component
{
    /// <summary>
    ///     The accents removed by the accentless trait.
    /// </summary>
    [DataField("removes", required: true), ViewVariables(VVAccess.ReadWrite)]
    public ComponentRegistry RemovedAccents = new();
}
