// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Client.UserInterface.Controls;

namespace Content.Client.Viewport
{
    /// <summary>
    ///     Client state that has a main viewport.
    /// </summary>
    /// <remarks>
    ///     Used for taking no-UI screenshots (including things like flash overlay).
    /// </remarks>
    public interface IMainViewportState
    {
        public MainViewport Viewport { get; }
    }
}
