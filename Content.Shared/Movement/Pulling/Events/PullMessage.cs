// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Movement.Pulling.Events;

public abstract class PullMessage : EntityEventArgs
{
    public readonly EntityUid PullerUid;
    public readonly EntityUid PulledUid;

    protected PullMessage(EntityUid pullerUid, EntityUid pulledUid)
    {
        PullerUid = pullerUid;
        PulledUid = pulledUid;
    }
}
