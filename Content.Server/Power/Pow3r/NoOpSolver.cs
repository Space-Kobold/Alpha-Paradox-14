// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Threading;

namespace Content.Server.Power.Pow3r
{
    public sealed class NoOpSolver : IPowerSolver
    {
        public void Tick(float frameTime, PowerState state, IParallelManager parallel)
        {
            // Literally nothing.
        }
    }
}
