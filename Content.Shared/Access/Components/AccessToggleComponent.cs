// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Access.Systems;
using Robust.Shared.GameStates;

namespace Content.Shared.Access.Components;

/// <summary>
/// Toggles an access provider with <c>ItemToggle</c>.
/// Requires <see cref="AccessComponent"/>.
/// </summary>
[RegisterComponent, NetworkedComponent, Access(typeof(AccessToggleSystem))]
public sealed partial class AccessToggleComponent : Component;
