// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Chat.Systems;

namespace Content.Server.Speech.Components;

/// <summary>
///     This component is used to relay speech events to other systems.
/// </summary>
[RegisterComponent]
public sealed partial class ActiveListenerComponent : Component
{
    [DataField("range")]
    public float Range = ChatSystem.VoiceRange;
}
