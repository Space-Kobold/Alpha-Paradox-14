// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Atmos;
using Content.Shared.Atmos;

namespace Content.Server.Mech.Components;

[RegisterComponent]
public sealed partial class MechAirComponent : Component
{
    //TODO: this doesn't support a tank implant for mechs or anything like that
    [DataField, ViewVariables(VVAccess.ReadWrite)]
    public GasMixture Air = new (GasMixVolume);

    public const float GasMixVolume = 70f;
}
