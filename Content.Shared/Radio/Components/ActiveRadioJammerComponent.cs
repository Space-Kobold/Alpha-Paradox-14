// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Radio.EntitySystems;
using Robust.Shared.GameStates;

namespace Content.Shared.Radio.Components;

/// <summary>
/// Prevents all radio in range from sending messages
/// </summary>
[RegisterComponent, NetworkedComponent]
[Access(typeof(SharedJammerSystem))]
public sealed partial class ActiveRadioJammerComponent : Component
{
}
