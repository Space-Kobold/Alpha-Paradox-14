// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.Power.Generator;

/// <summary>
/// This is used for stuff that can directly be shoved into a generator.
/// </summary>
[RegisterComponent, Access(typeof(GeneratorSystem))]
public sealed partial class ChemicalFuelGeneratorDirectSourceComponent : Component
{
    /// <summary>
    /// The solution to pull fuel material from.
    /// </summary>
    [DataField("solution", required: true), ViewVariables(VVAccess.ReadWrite)]
    public string Solution = default!;
}
