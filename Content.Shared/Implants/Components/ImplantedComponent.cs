// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Containers;
using Robust.Shared.GameStates;

namespace Content.Shared.Implants.Components;

/// <summary>
/// Added to an entity via the <see cref="SharedImplanterSystem"/> on implant
/// Used in instances where mob info needs to be passed to the implant such as MobState triggers
/// </summary>
[RegisterComponent, NetworkedComponent]
public sealed partial class ImplantedComponent : Component
{
    public Container ImplantContainer = default!;
}
