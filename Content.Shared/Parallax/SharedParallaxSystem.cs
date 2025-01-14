// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;
using Robust.Shared.Serialization;

namespace Content.Shared.Parallax;

/// <summary>
/// Handles per-map parallax in sim. Out of sim parallax is handled by ParallaxManager.
/// </summary>
public abstract class SharedParallaxSystem: EntitySystem
{
    [Serializable, NetSerializable]
    protected sealed class ParallaxComponentState : ComponentState
    {
        public string Parallax = string.Empty;
    }
}
