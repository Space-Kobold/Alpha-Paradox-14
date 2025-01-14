// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;

namespace Content.Shared.Bed.Cryostorage;

/// <summary>
/// Serves as a whitelist that allows an entity with this component to enter cryostorage.
/// It will also require MindContainerComponent.
/// </summary>
[RegisterComponent, NetworkedComponent]
public sealed partial class CanEnterCryostorageComponent : Component { }
