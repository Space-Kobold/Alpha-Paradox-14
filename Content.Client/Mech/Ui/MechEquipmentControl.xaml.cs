// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Client.AutoGenerated;
using Robust.Client.GameObjects;
using Robust.Client.UserInterface;
using Robust.Client.UserInterface.XAML;

namespace Content.Client.Mech.Ui;

[GenerateTypedNameReferences]
public sealed partial class MechEquipmentControl : Control
{
    public event Action? OnRemoveButtonPressed;

    public MechEquipmentControl(EntityUid entity, string itemName, Control? fragment)
    {
        RobustXamlLoader.Load(this);
        EquipmentName.SetMessage(itemName);
        EquipmentView.SetEntity(entity);
        RemoveButton.TexturePath = "/Textures/Interface/Nano/cross.svg.png";

        if (fragment != null)
        {
            Separator.Visible = true;
            CustomControlContainer.AddChild(fragment);
        }

        RemoveButton.OnPressed += _ => OnRemoveButtonPressed?.Invoke();
    }
}
