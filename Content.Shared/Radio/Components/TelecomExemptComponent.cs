// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;

namespace Content.Shared.Radio.Components;

/// <summary>
/// This is used for a radio that doesn't need a telecom server in order to broadcast.
/// </summary>
[RegisterComponent, NetworkedComponent]
public sealed partial class TelecomExemptComponent : Component;
