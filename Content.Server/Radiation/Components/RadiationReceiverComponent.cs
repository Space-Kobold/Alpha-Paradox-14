// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Radiation.Systems;
using Content.Shared.Radiation.Components;

namespace Content.Server.Radiation.Components;

/// <summary>
///     Marks component that receive radiation from <see cref="RadiationSourceComponent"/>.
/// </summary>
[RegisterComponent]
[Access(typeof(RadiationSystem))]
public sealed partial class RadiationReceiverComponent : Component
{
    /// <summary>
    ///     Current radiation value in rads per second.
    ///     Periodically updated by radiation system.
    /// </summary>
    [ViewVariables(VVAccess.ReadOnly)]
    public float CurrentRadiation;
}

