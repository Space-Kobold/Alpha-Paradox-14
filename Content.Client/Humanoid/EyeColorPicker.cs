// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Client.UserInterface;
using Robust.Client.UserInterface.Controls;

namespace Content.Client.Humanoid;

public sealed class EyeColorPicker : Control
{
    public event Action<Color>? OnEyeColorPicked;

    private readonly ColorSelectorSliders _colorSelectors;

    private Color _lastColor;

    public void SetData(Color color)
    {
        _lastColor = color;

        _colorSelectors.Color = color;
    }

    public EyeColorPicker()
    {
        var vBox = new BoxContainer
        {
            Orientation = BoxContainer.LayoutOrientation.Vertical
        };
        AddChild(vBox);

        vBox.AddChild(_colorSelectors = new ColorSelectorSliders());

        _colorSelectors.OnColorChanged += ColorValueChanged;
    }

    private void ColorValueChanged(Color newColor)
    {
        OnEyeColorPicked?.Invoke(newColor);

        _lastColor = newColor;
    }
}
