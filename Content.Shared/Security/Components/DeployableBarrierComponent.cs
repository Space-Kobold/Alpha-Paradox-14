// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Security.Systems;
using Robust.Shared.GameStates;

namespace Content.Shared.Security.Components;

[RegisterComponent, NetworkedComponent]
[Access(typeof(DeployableBarrierSystem))]
public sealed partial class DeployableBarrierComponent : Component
{
    /// <summary>
    ///     The fixture to change collision on.
    /// </summary>
    [DataField("fixture", required: true)] public string FixtureId = string.Empty;
}
