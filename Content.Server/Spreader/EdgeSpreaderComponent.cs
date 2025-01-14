// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Spreader;
using Robust.Shared.Prototypes;

namespace Content.Server.Spreader;

/// <summary>
/// Entity capable of becoming cloning and replicating itself to adjacent edges. See <see cref="SpreaderSystem"/>
/// </summary>
[RegisterComponent, Access(typeof(SpreaderSystem))]
public sealed partial class EdgeSpreaderComponent : Component
{
    [DataField(required:true)]
    public ProtoId<EdgeSpreaderPrototype> Id;
}
