// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Player;

namespace Content.Shared.Players;

/// <summary>
///     To be used from some systems.
///     Otherwise, use <see cref="ISharedPlayerManager"/>
/// </summary>
public abstract class SharedPlayerSystem : EntitySystem
{
    public abstract ContentPlayerData? ContentData(ICommonSession? session);
}
