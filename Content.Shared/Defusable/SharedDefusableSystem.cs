// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Serialization;

namespace Content.Shared.Defusable;

/// <summary>
/// This handles defusable explosives, such as Syndicate Bombs.
/// </summary>
/// <remarks>
/// Most of the logic is in the server
/// </remarks>
public abstract class SharedDefusableSystem : EntitySystem
{

}

[NetSerializable, Serializable]
public enum DefusableVisuals
{
    Active
}

[NetSerializable, Serializable]
public enum DefusableWireStatus
{
    LiveIndicator,
    BoltIndicator,
    BoomIndicator,
    DelayIndicator,
    ProceedIndicator,
}
