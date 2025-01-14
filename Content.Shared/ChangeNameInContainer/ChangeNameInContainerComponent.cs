// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Whitelist;
using Robust.Shared.GameStates;

namespace Content.Shared.ChangeNameInContainer;

/// <summary>
///     An entity with this component will get its name and verb chaned to the container it's inside of. E.g, if your a
///     pAI that has this component and are inside a lizard plushie, your name when talking will be "lizard plushie".
/// </summary>
[RegisterComponent, NetworkedComponent, Access(typeof(ChangeNameInContainerSystem))]
public sealed partial class ChangeVoiceInContainerComponent : Component
{
    /// <summary>
    ///     A whitelist of containers that will change the name.
    /// </summary>
    [DataField]
    public EntityWhitelist? Whitelist;
}
