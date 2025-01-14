// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.DeviceLinking.Components;

/// <summary>
/// This is used for automatic linkage with various receivers, like shutters.
/// </summary>
[RegisterComponent]
public sealed partial class AutoLinkTransmitterComponent : Component
{
    [DataField("channel", required: true)]
    public string AutoLinkChannel = default!;
}

