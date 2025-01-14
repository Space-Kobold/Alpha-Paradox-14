// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Research.Systems;
using Content.Shared.Whitelist;
using Robust.Shared.GameStates;

namespace Content.Shared.Research.Components;

/// <summary>
/// This is used for a lathe that can utilize <see cref="BlueprintComponent"/>s to gain more recipes.
/// </summary>
[RegisterComponent, NetworkedComponent, Access(typeof(BlueprintSystem))]
public sealed partial class BlueprintReceiverComponent : Component
{
    [DataField]
    public string ContainerId = "blueprint";

    [DataField(required: true)]
    public EntityWhitelist Whitelist = new();
}
