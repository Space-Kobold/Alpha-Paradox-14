// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.Coordinates;

[RegisterComponent]
public sealed partial class SpawnRandomOffsetComponent : Component
{
    [ViewVariables(VVAccess.ReadWrite)]
    [DataField("offset")] public float Offset = 0.5f;
}
