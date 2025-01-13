// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Client.Eui;
using Content.Shared.Eui;

namespace Content.Client.NPC;

public sealed class NPCEui : BaseEui
{
    private NPCWindow? _window = new();

    public override void Opened()
    {
        base.Opened();
        _window = new NPCWindow();
        _window.OpenCentered();
        _window.OnClose += OnClosed;
    }

    private void OnClosed()
    {
        SendMessage(new CloseEuiMessage());
    }

    public override void Closed()
    {
        base.Closed();
        _window?.Close();
        _window = null;
    }
}
