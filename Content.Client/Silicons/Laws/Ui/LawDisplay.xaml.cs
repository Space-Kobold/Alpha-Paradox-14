// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Client.Chat.Managers;
using Content.Client.Message;
using Content.Shared.Chat;
using Content.Shared.Radio;
using Content.Shared.Silicons.Laws;
using Content.Shared.Speech;
using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface;
using Robust.Client.UserInterface.Controls;
using Robust.Client.UserInterface.XAML;
using Robust.Shared.Prototypes;
using Robust.Shared.Timing;
using Robust.Shared.Utility;

namespace Content.Client.Silicons.Laws.Ui;

[GenerateTypedNameReferences]
public sealed partial class LawDisplay : Control
{
    [Dependency] private readonly IPrototypeManager _prototypeManager = default!;
    [Dependency] private readonly IChatManager _chatManager = default!;
    [Dependency] private readonly IGameTiming _timing = default!;
    [Dependency] private readonly EntityManager _entityManager = default!;

    private static readonly TimeSpan PressCooldown = TimeSpan.FromSeconds(3);

    private readonly Dictionary<Button, TimeSpan> _nextAllowedPress = new();

    public LawDisplay(EntityUid uid, SiliconLaw law, HashSet<string>? radioChannels)
    {
        RobustXamlLoader.Load(this);
        IoCManager.InjectDependencies(this);

        var identifier = law.LawIdentifierOverride ?? $"{law.Order}";
        var lawIdentifier = Loc.GetString("laws-ui-law-header", ("id", identifier));
        var lawDescription = Loc.GetString(law.LawString);
        var lawIdentifierPlaintext = FormattedMessage.RemoveMarkupPermissive(lawIdentifier);
        var lawDescriptionPlaintext = FormattedMessage.RemoveMarkupPermissive(lawDescription);

        LawNumberLabel.SetMarkup(lawIdentifier);
        LawLabel.SetMessage(lawDescription);

        // If you can't talk, you can't state your laws...
        if (!_entityManager.TryGetComponent<SpeechComponent>(uid, out var speech) || speech.SpeechSounds is null)
            return;

        var localButton = new Button
        {
            Text = Loc.GetString("hud-chatbox-select-channel-Local"),
            Modulate = Color.DarkGray,
            StyleClasses = { "chatSelectorOptionButton" },
            MinHeight = 35,
            MinWidth = 75,
        };

        _nextAllowedPress[localButton] = TimeSpan.Zero;

        localButton.OnPressed += _ =>
        {
            _chatManager.SendMessage($"{lawIdentifierPlaintext}: {lawDescriptionPlaintext}", ChatSelectChannel.Local);
            _nextAllowedPress[localButton] = _timing.CurTime + PressCooldown;
        };

        LawAnnouncementButtons.AddChild(localButton);

        if (radioChannels == null)
            return;

        foreach (var radioChannel in radioChannels)
        {
            if (!_prototypeManager.TryIndex<RadioChannelPrototype>(radioChannel, out var radioChannelProto))
                continue;

            var radioChannelButton = new Button
            {
                Text = Loc.GetString(radioChannelProto.Name),
                Modulate = radioChannelProto.Color,
                StyleClasses = { "chatSelectorOptionButton" },
                MinHeight = 35,
                MinWidth = 75,
            };

            _nextAllowedPress[radioChannelButton] = TimeSpan.Zero;

            radioChannelButton.OnPressed += _ =>
            {
                switch (radioChannel)
                {
                    case SharedChatSystem.CommonChannel:
                        _chatManager.SendMessage($"{SharedChatSystem.RadioCommonPrefix} {lawIdentifierPlaintext}: {lawDescriptionPlaintext}", ChatSelectChannel.Radio); break;
                    default:
                        _chatManager.SendMessage($"{SharedChatSystem.RadioChannelPrefix}{radioChannelProto.KeyCode} {lawIdentifierPlaintext}: {lawDescriptionPlaintext}", ChatSelectChannel.Radio); break;
                }
                _nextAllowedPress[radioChannelButton] = _timing.CurTime + PressCooldown;
            };

            LawAnnouncementButtons.AddChild(radioChannelButton);
        }
    }

    protected override void FrameUpdate(FrameEventArgs args)
    {
        base.FrameUpdate(args);

        var curTime = _timing.CurTime;
        foreach (var (button, nextPress) in _nextAllowedPress)
        {
            button.Disabled = curTime < nextPress;
        }
    }
}
