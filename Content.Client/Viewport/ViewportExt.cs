// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Client.UserInterface.CustomControls;

namespace Content.Client.Viewport
{
    public static class ViewportExt
    {
        public static int GetRenderScale(this IViewportControl viewport)
        {
            if (viewport is ScalingViewport svp)
                return svp.CurrentRenderScale;

            return 1;
        }
    }
}
