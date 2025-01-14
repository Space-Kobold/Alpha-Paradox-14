// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Audio;
using Robust.Shared.GameStates;

namespace Content.Shared.Salvage.Fulton;

/// <summary>
/// Receives <see cref="FultonedComponent"/>.
/// </summary>
[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
public sealed partial class FultonBeaconComponent : Component
{
    [ViewVariables(VVAccess.ReadWrite), DataField("soundLink"), AutoNetworkedField]
    public SoundSpecifier? LinkSound = new SoundPathSpecifier("/Audio/Items/beep.ogg");
}
