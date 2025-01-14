// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.Gateway.Components;

/// <summary>
/// Destination created by <see cref="GatewayGeneratorComponent"/>
/// </summary>
[RegisterComponent]
public sealed partial class GatewayGeneratorDestinationComponent : Component
{
    /// <summary>
    /// Generator that created this destination.
    /// </summary>
    [DataField]
    public EntityUid Generator;

    /// <summary>
    /// Is the map locked from being used still or unlocked.
    /// Used in conjunction with the attached generator's NextUnlock.
    /// </summary>
    [DataField]
    public bool Locked = true;

    [DataField]
    public bool Loaded;

    /// <summary>
    /// Seed used for this destination.
    /// </summary>
    [DataField]
    public int Seed;

    /// <summary>
    /// Origin of the gateway.
    /// </summary>
    [DataField]
    public Vector2i Origin;
}

