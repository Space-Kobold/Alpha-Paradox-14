// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Pulling.Events
{
    /// <summary>
    ///     Directed event raised on the puller to see if it can start pulling something.
    /// </summary>
    public sealed class StartPullAttemptEvent : CancellableEntityEventArgs
    {
        public StartPullAttemptEvent(EntityUid puller, EntityUid pulled)
        {
            Puller = puller;
            Pulled = pulled;
        }

        public EntityUid Puller { get; }
        public EntityUid Pulled { get; }
    }
}
