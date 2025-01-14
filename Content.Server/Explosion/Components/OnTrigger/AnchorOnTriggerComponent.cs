// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Explosion.EntitySystems;

namespace Content.Server.Explosion.Components;

/// <summary>
/// Will anchor the attached entity upon a <see cref="TriggerEvent"/>.
/// </summary>
[RegisterComponent]
public sealed partial class AnchorOnTriggerComponent : Component
{
    [DataField("removeOnTrigger")]
    public bool RemoveOnTrigger = true;
}
