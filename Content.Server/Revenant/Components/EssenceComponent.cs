// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.Revenant.Components;

[RegisterComponent]
public sealed partial class EssenceComponent : Component
{
    /// <summary>
    /// Whether or not the entity has been harvested yet.
    /// </summary>
    [ViewVariables(VVAccess.ReadWrite)]
    public bool Harvested = false;

    /// <summary>
    /// Whether or not a revenant has searched this entity
    /// for its soul yet.
    /// </summary>
    [ViewVariables(VVAccess.ReadWrite)]
    public bool SearchComplete = false;

    /// <summary>
    /// The total amount of Essence that the entity has.
    /// Changes based on mob state.
    /// </summary>
    [ViewVariables(VVAccess.ReadWrite)]
    public float EssenceAmount = 0f;
}
