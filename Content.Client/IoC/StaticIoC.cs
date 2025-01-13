// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Client.ResourceManagement;
using Robust.Shared.ContentPack;
using Robust.Shared.IoC;

namespace Content.Client.IoC
{
    public static class StaticIoC
    {
        public static IResourceCache ResC => IoCManager.Resolve<IResourceCache>();
    }
}
