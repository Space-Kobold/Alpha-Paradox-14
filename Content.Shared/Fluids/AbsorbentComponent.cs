// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Audio;
using Content.Shared.FixedPoint;
using Robust.Shared.Audio;
using Robust.Shared.GameStates;

namespace Content.Shared.Fluids;

/// <summary>
/// For entities that can clean up puddles
/// </summary>
[RegisterComponent, NetworkedComponent]
public sealed partial class AbsorbentComponent : Component
{
    public const string SolutionName = "absorbed";

    public Dictionary<Color, float> Progress = new();

    /// <summary>
    /// How much solution we can transfer in one interaction.
    /// </summary>
    [DataField("pickupAmount")]
    public FixedPoint2 PickupAmount = FixedPoint2.New(100);

    [DataField("pickupSound")]
    public SoundSpecifier PickupSound = new SoundPathSpecifier("/Audio/Effects/Fluids/watersplash.ogg")
    {
        Params = AudioParams.Default.WithVariation(SharedContentAudioSystem.DefaultVariation),
    };

    [DataField("transferSound")] public SoundSpecifier TransferSound =
        new SoundPathSpecifier("/Audio/Effects/Fluids/slosh.ogg")
        {
            Params = AudioParams.Default.WithVariation(SharedContentAudioSystem.DefaultVariation).WithVolume(-3f),
        };

    public static readonly SoundSpecifier DefaultTransferSound =
        new SoundPathSpecifier("/Audio/Effects/Fluids/slosh.ogg")
        {
            Params = AudioParams.Default.WithVariation(SharedContentAudioSystem.DefaultVariation).WithVolume(-3f),
        };
}
