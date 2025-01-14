// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using System.Text.RegularExpressions;
using Content.Server.Chat;
using Content.Server.Chat.Systems;

namespace Content.Server.Speech
{
    public sealed class AccentSystem : EntitySystem
    {
        public static readonly Regex SentenceRegex = new(@"(?<=[\.!\?‽])(?![\.!\?‽])", RegexOptions.Compiled);

        public override void Initialize()
        {
            SubscribeLocalEvent<TransformSpeechEvent>(AccentHandler);
        }

        private void AccentHandler(TransformSpeechEvent args)
        {
            var accentEvent = new AccentGetEvent(args.Sender, args.Message);

            RaiseLocalEvent(args.Sender, accentEvent, true);
            args.Message = accentEvent.Message;
        }
    }

    public sealed class AccentGetEvent : EntityEventArgs
    {
        /// <summary>
        ///     The entity to apply the accent to.
        /// </summary>
        public EntityUid Entity { get; }

        /// <summary>
        ///     The message to apply the accent transformation to.
        ///     Modify this to apply the accent.
        /// </summary>
        public string Message { get; set; }

        public AccentGetEvent(EntityUid entity, string message)
        {
            Entity = entity;
            Message = message;
        }
    }
}
