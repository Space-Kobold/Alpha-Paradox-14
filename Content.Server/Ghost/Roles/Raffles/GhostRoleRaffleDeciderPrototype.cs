// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Prototypes;

namespace Content.Server.Ghost.Roles.Raffles;

/// <summary>
/// Allows getting a <see cref="IGhostRoleRaffleDecider"/> as prototype.
/// </summary>
[Prototype("ghostRoleRaffleDecider")]
public sealed class GhostRoleRaffleDeciderPrototype : IPrototype
{
    /// <inheritdoc />
    [IdDataField]
    public string ID { get; private set; } = default!;

    /// <summary>
    /// The <see cref="IGhostRoleRaffleDecider"/> instance that chooses the winner of a raffle.
    /// </summary>
    [DataField("decider", required: true)]
    public IGhostRoleRaffleDecider Decider { get; private set; } = new RngGhostRoleRaffleDecider();
}
