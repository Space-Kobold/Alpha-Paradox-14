// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Weapons.Ranged.Components;
using Robust.Client.UserInterface;

namespace Content.Client.Weapons.Ranged.Components;

[RegisterComponent]
public sealed partial class AmmoCounterComponent : SharedAmmoCounterComponent
{
    public Control? Control;
}
