// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Thief.Systems;
using Content.Shared.Thief;
using Robust.Shared.Audio;
using Robust.Shared.Prototypes;

namespace Content.Server.Thief.Components;

/// <summary>
/// This component stores the possible contents of the backpack,
/// which can be selected via the interface.
/// </summary>
[RegisterComponent, Access(typeof(ThiefUndeterminedBackpackSystem))]
public sealed partial class ThiefUndeterminedBackpackComponent : Component
{
    /// <summary>
    /// List of sets available for selection
    /// </summary>
    [DataField]
    public List<ProtoId<ThiefBackpackSetPrototype>> PossibleSets = new();

    [DataField]
    public List<int> SelectedSets = new();

    [DataField]
    public SoundSpecifier ApproveSound = new SoundPathSpecifier("/Audio/Effects/rustle1.ogg");

    /// <summary>
    /// Max number of sets you can select.
    /// </summary>
    [DataField]
    public int MaxSelectedSets = 2;
}
