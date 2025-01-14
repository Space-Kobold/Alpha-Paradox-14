// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Module;

namespace Content.Server.IoC
{
    public sealed class ServerModuleTestingCallbacks : SharedModuleTestingCallbacks
    {
        public Action? ServerBeforeIoC { get; set; }
    }
}
