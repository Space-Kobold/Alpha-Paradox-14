// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;

namespace Content.Shared.Foldable;

[RegisterComponent, NetworkedComponent]
[Access(typeof(DeployFoldableSystem))]
public sealed partial class DeployFoldableComponent : Component;
