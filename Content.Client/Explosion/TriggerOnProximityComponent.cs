// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Explosion;
using Content.Shared.Explosion.Components;

namespace Content.Client.Explosion;

[RegisterComponent, Access(typeof(TriggerSystem))]
public sealed partial class TriggerOnProximityComponent : SharedTriggerOnProximityComponent {}
