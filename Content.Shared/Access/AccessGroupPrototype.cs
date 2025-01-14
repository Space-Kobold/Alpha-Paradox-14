// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Access.Components;
using Robust.Shared.Prototypes;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom.Prototype.Set;

namespace Content.Shared.Access;

/// <summary>
///     Contains a list of access tags that are part of this group.
///     Used by <see cref="AccessComponent"/> to avoid boilerplate.
/// </summary>
[Prototype("accessGroup")]
public sealed partial class AccessGroupPrototype : IPrototype
{
    [IdDataField]
    public string ID { get; private set; } = default!;

    [DataField("tags", required: true)]
    public HashSet<ProtoId<AccessLevelPrototype>> Tags = default!;
}
