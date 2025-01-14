// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.DeviceLinking;
using Robust.Shared.Prototypes;

namespace Content.Server.Shuttles.Components;

[RegisterComponent]
public sealed partial class DockingSignalControlComponent : Component
{
    /// <summary>
    /// Output port that is high while docked.
    /// </summary>
    [DataField]
    public ProtoId<SourcePortPrototype> DockStatusSignalPort = "DockStatus";
}
