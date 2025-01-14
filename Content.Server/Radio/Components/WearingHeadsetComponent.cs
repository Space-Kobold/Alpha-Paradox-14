// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Radio.EntitySystems;

namespace Content.Server.Radio.Components;

/// <summary>
///     This component is used to tag players that are currently wearing an ACTIVE headset.
/// </summary>
[RegisterComponent]
public sealed partial class WearingHeadsetComponent : Component
{
    [DataField("headset")]
    public EntityUid Headset;
}
