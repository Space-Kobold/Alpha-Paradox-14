// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Storage.Components;

/// <summary>
///     Added to entities contained within entity storage, for directed event purposes.
/// </summary>
[RegisterComponent]
public sealed partial class InsideEntityStorageComponent : Component
{
    public EntityUid Storage;
}
