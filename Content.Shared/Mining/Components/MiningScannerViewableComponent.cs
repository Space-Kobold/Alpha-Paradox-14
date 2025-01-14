// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;
using Robust.Shared.Serialization;

namespace Content.Shared.Mining.Components;

[RegisterComponent, NetworkedComponent, Access(typeof(MiningScannerSystem))]
public sealed partial class MiningScannerViewableComponent : Component;

[Serializable, NetSerializable]
public enum MiningScannerVisualLayers : byte
{
    Overlay
}
