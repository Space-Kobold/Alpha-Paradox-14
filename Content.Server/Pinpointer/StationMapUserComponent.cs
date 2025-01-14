// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.Pinpointer;

/// <summary>
/// Added to an entity using station map so when its parent changes we reset it.
/// </summary>
[RegisterComponent]
public sealed partial class StationMapUserComponent : Component
{
    [DataField("mapUid")]
    public EntityUid Map;
}
