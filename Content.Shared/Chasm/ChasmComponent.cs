// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Audio;
using Robust.Shared.GameStates;

namespace Content.Shared.Chasm;

/// <summary>
///     Marks a component that will cause entities to fall into them on a step trigger activation
/// </summary>
[NetworkedComponent, RegisterComponent, Access(typeof(ChasmSystem))]
public sealed partial class ChasmComponent : Component
{
    /// <summary>
    ///     Sound that should be played when an entity falls into the chasm
    /// </summary>
    [DataField("fallingSound")]
    public SoundSpecifier FallingSound = new SoundPathSpecifier("/Audio/Effects/falling.ogg");
}
