// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Radio;
using Content.Shared.Radio.Components;
using JetBrains.Annotations;
using Robust.Client.GameObjects;
using Robust.Client.UserInterface;

namespace Content.Client.Radio.Ui;

[UsedImplicitly]
public sealed class IntercomBoundUserInterface : BoundUserInterface
{
    [ViewVariables]
    private IntercomMenu? _menu;

    public IntercomBoundUserInterface(EntityUid owner, Enum uiKey) : base(owner, uiKey)
    {

    }

    protected override void Open()
    {
        base.Open();

        _menu = this.CreateWindow<IntercomMenu>();

        if (EntMan.TryGetComponent(Owner, out IntercomComponent? intercom))
        {
            _menu.Update((Owner, intercom));
        }

        _menu.OnMicPressed += enabled =>
        {
            SendMessage(new ToggleIntercomMicMessage(enabled));
        };
        _menu.OnSpeakerPressed += enabled =>
        {
            SendMessage(new ToggleIntercomSpeakerMessage(enabled));
        };
        _menu.OnChannelSelected += channel =>
        {
            SendMessage(new SelectIntercomChannelMessage(channel));
        };
    }

    public void Update(Entity<IntercomComponent> ent)
    {
        _menu?.Update(ent);
    }
}
