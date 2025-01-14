// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Audio;
using Robust.Shared.GameStates;
using Robust.Shared.Map;

namespace Content.Shared.Mining.Components;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState, AutoGenerateComponentPause, Access(typeof(MiningScannerSystem))]
public sealed partial class MiningScannerViewerComponent : Component
{
    [DataField, ViewVariables(VVAccess.ReadOnly), AutoNetworkedField]
    public float ViewRange;

    [DataField, AutoNetworkedField]
    public float AnimationDuration = 1.5f;

    [DataField, AutoNetworkedField]
    public TimeSpan PingDelay = TimeSpan.FromSeconds(5);

    [DataField, AutoNetworkedField, AutoPausedField]
    public TimeSpan NextPingTime = TimeSpan.MaxValue;

    [DataField]
    public EntityCoordinates? LastPingLocation;

    [DataField, AutoNetworkedField]
    public SoundSpecifier? PingSound = new SoundPathSpecifier("/Audio/Machines/sonar-ping.ogg")
    {
        Params = new AudioParams
        {
            Volume = -3,
        }
    };

    [DataField]
    public bool QueueRemoval;
}
