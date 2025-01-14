// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.CPUJob.JobQueues.Queues;

namespace Content.Server.CPUJob.JobQueues.Queues
{
    public sealed class PathfindingJobQueue : JobQueue
    {
        public override double MaxTime => 0.003;
    }
}
