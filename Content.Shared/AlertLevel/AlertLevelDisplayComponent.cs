// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.AlertLevel;

[RegisterComponent]
public sealed partial class AlertLevelDisplayComponent : Component
{
    [DataField("alertVisuals")]
    public  Dictionary<string, string> AlertVisuals = new();
}
