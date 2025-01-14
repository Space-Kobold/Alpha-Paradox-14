// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Kitchen;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom;

namespace Content.Server.Kitchen.Components;

/// <summary>
/// Attached to a microwave that is currently in the process of cooking
/// </summary>
[RegisterComponent, AutoGenerateComponentPause]
public sealed partial class ActiveMicrowaveComponent : Component
{
    [ViewVariables(VVAccess.ReadWrite)]
    public float CookTimeRemaining;

    [ViewVariables(VVAccess.ReadWrite)]
    public float TotalTime;

    [ViewVariables(VVAccess.ReadWrite)]
    [DataField(customTypeSerializer: typeof(TimeOffsetSerializer))]
    [AutoPausedField]
    public TimeSpan MalfunctionTime = TimeSpan.Zero;

    [ViewVariables]
    public (FoodRecipePrototype?, int) PortionedRecipe;
}
