// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Client.Clickable;

[RegisterComponent]
public sealed partial class ClickableComponent : Component
{
    [DataField] public DirBoundData? Bounds;

    [DataDefinition]
    public sealed partial class DirBoundData
    {
        [DataField] public Box2 All;
        [DataField] public Box2 North;
        [DataField] public Box2 South;
        [DataField] public Box2 East;
        [DataField] public Box2 West;
    }
}
