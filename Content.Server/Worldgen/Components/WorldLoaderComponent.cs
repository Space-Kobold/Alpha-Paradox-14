// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Worldgen.Systems;

namespace Content.Server.Worldgen.Components;

/// <summary>
///     This is used for allowing some objects to load the game world.
/// </summary>
[RegisterComponent]
[Access(typeof(WorldControllerSystem))]
public sealed partial class WorldLoaderComponent : Component
{
    /// <summary>
    ///     The radius in which the loader loads the world.
    /// </summary>
    [ViewVariables(VVAccess.ReadWrite)] [DataField("radius")]
    public int Radius = 128;
}

