// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Client.Administration.Managers;
using Robust.Client.AutoGenerated;
using Robust.Client.Graphics;
using Robust.Client.UserInterface.Controls;
using Robust.Client.UserInterface.XAML;

namespace Content.Client.Administration.UI.Tabs.ObjectsTab;

[GenerateTypedNameReferences]
public sealed partial class ObjectsTabEntry : PanelContainer
{
    public NetEntity AssocEntity;

    public Action<NetEntity>? OnTeleport;
    public Action<NetEntity>? OnDelete;
    private readonly Dictionary<Button, ConfirmationData> _confirmations = new();

    public ObjectsTabEntry(IClientAdminManager manager, string name, NetEntity nent, StyleBox styleBox)
    {
        RobustXamlLoader.Load(this);

        AssocEntity = nent;
        EIDLabel.Text = nent.ToString();
        NameLabel.Text = name;
        BackgroundColorPanel.PanelOverride = styleBox;

        TeleportButton.Disabled = !manager.CanCommand("tpto");
        DeleteButton.Disabled = !manager.CanCommand("delete");

        TeleportButton.OnPressed += _ => OnTeleport?.Invoke(nent);
        DeleteButton.OnPressed += _ =>
        {
            if (!AdminUIHelpers.TryConfirm(DeleteButton, _confirmations))
            {
                return;
            }
            OnDelete?.Invoke(nent);
        };
    }
}
