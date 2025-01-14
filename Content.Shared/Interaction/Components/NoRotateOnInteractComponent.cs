// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;

namespace Content.Shared.Interaction.Components;

/// <summary>
/// This is used for entities which should not rotate on interactions (for instance those who use <see cref="MouseRotator"/> instead)
/// </summary>
[RegisterComponent, NetworkedComponent]
public sealed partial class NoRotateOnInteractComponent : Component
{
}
