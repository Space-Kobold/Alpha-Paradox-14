// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.Medical.Components;

/// <summary>
/// Tracking component for an enabled cryo pod (which periodically tries to inject chemicals in the occupant, if one exists)
/// </summary>
[RegisterComponent]
public sealed partial class ActiveCryoPodComponent : Component
{
}
