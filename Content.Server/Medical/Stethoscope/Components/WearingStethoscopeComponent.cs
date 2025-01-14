// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using System.Threading;

namespace Content.Server.Medical.Components
{
    /// <summary>
    /// Used to let doctors use the stethoscope on people.
    /// </summary>
    [RegisterComponent]
    public sealed partial class WearingStethoscopeComponent : Component
    {
        public CancellationTokenSource? CancelToken;

        [DataField("delay")]
        public float Delay = 2.5f;

        public EntityUid Stethoscope = default!;
    }
}
