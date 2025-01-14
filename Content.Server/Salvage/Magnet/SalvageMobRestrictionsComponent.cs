// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.Salvage.Magnet;

// This is dumb
/// <summary>
/// Deletes the attached entity if the linked entity is deleted.
/// </summary>
[RegisterComponent]
public sealed partial class SalvageMobRestrictionsComponent : Component
{
    [DataField, ViewVariables(VVAccess.ReadWrite)]
    public EntityUid LinkedEntity;
}
