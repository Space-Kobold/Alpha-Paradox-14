// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Audio;

namespace Content.Server.Cargo.Components;

[RegisterComponent]
public sealed partial class CargoShuttleConsoleComponent : Component
{
    [ViewVariables(VVAccess.ReadWrite), DataField("soundDeny")]
    public SoundSpecifier DenySound = new SoundPathSpecifier("/Audio/Effects/Cargo/buzz_two.ogg");
}
