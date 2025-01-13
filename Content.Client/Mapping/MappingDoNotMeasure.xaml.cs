// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using System.Numerics;
using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface;
using Robust.Client.UserInterface.XAML;

namespace Content.Client.Mapping;

[GenerateTypedNameReferences]
public sealed partial class MappingDoNotMeasure : Control
{
    public MappingDoNotMeasure()
    {
        RobustXamlLoader.Load(this);
    }

    protected override Vector2 MeasureOverride(Vector2 availableSize)
    {
        return Vector2.Zero;
    }
}

