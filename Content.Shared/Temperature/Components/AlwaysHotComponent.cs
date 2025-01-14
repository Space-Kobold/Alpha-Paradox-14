// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Temperature.Systems;

namespace Content.Shared.Temperature.Components;

/// <summary>
/// Makes the entity always set <c>IsHotEvent.IsHot</c> to true, no matter what.
/// </summary>
[RegisterComponent, Access(typeof(AlwaysHotSystem))]
public sealed partial class AlwaysHotComponent : Component
{
}
