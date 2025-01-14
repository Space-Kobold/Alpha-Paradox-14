// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.DoAfter;

namespace Content.Server.Resist;

[RegisterComponent]
public sealed partial class CanEscapeInventoryComponent : Component
{
    /// <summary>
    /// Base doafter length for uncontested breakouts.
    /// </summary>
    [DataField("baseResistTime")]
    public float BaseResistTime = 5f;

    public bool IsEscaping => DoAfter != null;

    [DataField("doAfter")]
    public DoAfterId? DoAfter;
}
