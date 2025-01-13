// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface.Controls;
using Robust.Client.UserInterface.XAML;

namespace Content.Client.Silicons.Borgs;

[GenerateTypedNameReferences]
public sealed partial class BorgModuleControl : PanelContainer
{
    public Action? RemoveButtonPressed;

    public BorgModuleControl(EntityUid entity, IEntityManager entityManager, bool canRemove)
    {
        RobustXamlLoader.Load(this);

        ModuleView.SetEntity(entity);
        ModuleName.Text = entityManager.GetComponent<MetaDataComponent>(entity).EntityName;
        RemoveButton.TexturePath = "/Textures/Interface/Nano/cross.svg.png";
        RemoveButton.OnPressed += _ =>
        {
            RemoveButtonPressed?.Invoke();
        };
        RemoveButton.Visible = canRemove;
    }
}

