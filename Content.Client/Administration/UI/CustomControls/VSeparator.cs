// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using System.Numerics;
using Robust.Client.Graphics;
using Robust.Client.UserInterface.Controls;
using Robust.Shared.Maths;

namespace Content.Client.Administration.UI.CustomControls;

public sealed class VSeparator : PanelContainer
{
    private static readonly Color SeparatorColor = Color.FromHex("#3D4059");

    public VSeparator(Color color)
    {
        MinSize = new Vector2(2, 5);

        AddChild(new PanelContainer
        {
            PanelOverride = new StyleBoxFlat
            {
                BackgroundColor = color
            }
        });
    }

    public VSeparator() : this(SeparatorColor) { }
}
