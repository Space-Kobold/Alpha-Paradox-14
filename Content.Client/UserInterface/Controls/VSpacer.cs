// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Client.Graphics;
using Robust.Client.UserInterface;
using Robust.Client.UserInterface.Controls;
using Robust.Shared.Maths;

namespace Content.Client.UserInterface.Controls;

public sealed class VSpacer : Control
{
    public float Spacing{ get => MinWidth; set => MinWidth = value; }
    public VSpacer()
    {
        MinWidth = Spacing;
    }
    public VSpacer(float width = 5)
    {
        Spacing = width;
        MinWidth = width;
    }
}
