// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;
using Robust.Shared.Prototypes;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom.Prototype;

namespace Content.Shared.Cargo.Components;

/// <summary>
/// Present on cargo shuttles to provide metadata such as preventing spam calling.
/// </summary>
[RegisterComponent, NetworkedComponent, Access(typeof(SharedCargoSystem))]
public sealed partial class CargoShuttleComponent : Component
{
    /*
     * Still needed for drone console for now.
     */
}
