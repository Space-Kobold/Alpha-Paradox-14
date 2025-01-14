// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Chat.Systems;
using Content.Server.Speech.Components;

namespace Content.Server.Speech.EntitySystems
{
    public sealed class UnblockableSpeechSystem : EntitySystem
    {
        public override void Initialize()
        {
            SubscribeLocalEvent<UnblockableSpeechComponent, CheckIgnoreSpeechBlockerEvent>(OnCheck);
        }

        private void OnCheck(EntityUid uid, UnblockableSpeechComponent component, CheckIgnoreSpeechBlockerEvent args)
        {
            args.IgnoreBlocker = true;
        }
    }
}
