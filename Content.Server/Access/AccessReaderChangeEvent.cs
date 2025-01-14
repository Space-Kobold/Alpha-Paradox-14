// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.Access
{
    public sealed class AccessReaderChangeEvent : EntityEventArgs
    {
        public EntityUid Sender { get; }

        public bool Enabled { get; }

        public AccessReaderChangeEvent(EntityUid entity, bool enabled)
        {
            Sender = entity;
            Enabled = enabled;
        }
    }
}
