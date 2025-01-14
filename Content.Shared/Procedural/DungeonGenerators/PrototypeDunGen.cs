// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Prototypes;

namespace Content.Shared.Procedural.DungeonGenerators;

/// <summary>
/// Runs another <see cref="DungeonConfig"/>.
/// Used for storing data on 1 system.
/// </summary>
public sealed partial class PrototypeDunGen : IDunGenLayer
{
    [DataField(required: true)]
    public ProtoId<DungeonConfigPrototype> Proto;
}
