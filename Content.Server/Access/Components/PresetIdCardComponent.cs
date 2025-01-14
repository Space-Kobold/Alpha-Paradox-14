// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Roles;
using Robust.Shared.Prototypes;

namespace Content.Server.Access.Components;

[RegisterComponent]
public sealed partial class PresetIdCardComponent : Component
{
    [DataField("job")]
    public ProtoId<JobPrototype>? JobName;

    [DataField("name")]
    public string? IdName;
}
