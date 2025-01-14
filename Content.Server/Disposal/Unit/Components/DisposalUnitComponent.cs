// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Atmos;
using Content.Shared.Atmos;
using Content.Shared.Disposal.Components;

namespace Content.Server.Disposal.Unit.Components;

// GasMixture life.
[RegisterComponent]
public sealed partial class DisposalUnitComponent : SharedDisposalUnitComponent
{
    [DataField("air")]
    public GasMixture Air = new(Atmospherics.CellVolume);
}
