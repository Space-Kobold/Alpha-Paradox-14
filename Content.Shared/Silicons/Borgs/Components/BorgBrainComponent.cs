// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;

namespace Content.Shared.Silicons.Borgs.Components;

/// <summary>
/// This is used for brains and mind receptacles
/// that can be inserted into a borg to transfer a mind.
/// </summary>
[RegisterComponent, NetworkedComponent, Access(typeof(SharedBorgSystem))]
public sealed partial class BorgBrainComponent : Component
{

}
