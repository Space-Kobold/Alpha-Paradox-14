// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Actions.Events;

public sealed class DisarmAttemptEvent : CancellableEntityEventArgs
{
    public readonly EntityUid TargetUid;
    public readonly EntityUid DisarmerUid;
    public readonly EntityUid? TargetItemInHandUid;

    public DisarmAttemptEvent(EntityUid targetUid, EntityUid disarmerUid, EntityUid? targetItemInHandUid = null)
    {
        TargetUid = targetUid;
        DisarmerUid = disarmerUid;
        TargetItemInHandUid = targetItemInHandUid;
    }
}