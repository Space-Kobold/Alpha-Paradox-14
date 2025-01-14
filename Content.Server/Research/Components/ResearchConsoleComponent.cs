// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Radio;
using Robust.Shared.Prototypes;

namespace Content.Server.Research.Components;

[RegisterComponent]
public sealed partial class ResearchConsoleComponent : Component
{
    /// <summary>
    /// The radio channel that the unlock announcements are broadcast to.
    /// </summary>
    [DataField, ViewVariables(VVAccess.ReadWrite)]
    public ProtoId<RadioChannelPrototype> AnnouncementChannel = "Science";
}

