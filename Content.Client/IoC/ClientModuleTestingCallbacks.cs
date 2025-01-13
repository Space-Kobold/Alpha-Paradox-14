// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using System;
using Content.Shared;
using Content.Shared.Module;

namespace Content.Client.IoC
{
    public sealed class ClientModuleTestingCallbacks : SharedModuleTestingCallbacks
    {
        public Action? ClientBeforeIoC { get; set; }
    }
}
