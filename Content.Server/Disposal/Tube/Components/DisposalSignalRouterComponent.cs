// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Disposal.Tube.Systems;
using Content.Shared.DeviceLinking;
using Robust.Shared.Prototypes;

namespace Content.Server.Disposal.Tube.Components;

/// <summary>
/// Requires <see cref="DisposalJunctionComponent"/> to function.
/// </summary>
[RegisterComponent, Access(typeof(DisposalSignalRouterSystem))]
public sealed partial class DisposalSignalRouterComponent : Component
{
    /// <summary>
    /// Whether to route items to the side or not.
    /// </summary>
    [DataField]
    public bool Routing;

    /// <summary>
    /// Port that sets the router to send items to the side.
    /// </summary>
    [DataField]
    public ProtoId<SinkPortPrototype> OnPort = "On";

    /// <summary>
    /// Port that sets the router to send items ahead.
    /// </summary>
    [DataField]
    public ProtoId<SinkPortPrototype> OffPort = "Off";

    /// <summary>
    /// Port that toggles the router between sending items to the side and ahead.
    /// </summary>
    [DataField]
    public ProtoId<SinkPortPrototype> TogglePort = "Toggle";
}
