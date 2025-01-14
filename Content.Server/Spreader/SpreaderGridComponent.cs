// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.Spreader;

[RegisterComponent]
public sealed partial class SpreaderGridComponent : Component
{
    [DataField]
    public float UpdateAccumulator = SpreaderSystem.SpreadCooldownSeconds;
}
