// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using System.Collections.Generic;
using System.Reflection;
using Content.Server.Administration.Managers;
using Robust.Shared.Toolshed;

namespace Content.IntegrationTests.Tests.Toolshed;

[TestFixture]
public sealed class AdminTest : ToolshedTest
{
    [Test]
    public async Task AllCommandsHavePermissions()
    {
        var toolMan = Server.ResolveDependency<ToolshedManager>();
        var admin = Server.ResolveDependency<IAdminManager>();
        var ignored = new HashSet<Assembly>()
            {typeof(LocTest).Assembly, typeof(Robust.UnitTesting.Shared.Toolshed.LocTest).Assembly};

        await Server.WaitAssertion(() =>
        {
            Assert.Multiple(() =>
            {
                foreach (var cmd in toolMan.DefaultEnvironment.AllCommands())
                {
                    if (ignored.Contains(cmd.Cmd.GetType().Assembly))
                        continue;

                    Assert.That(admin.TryGetCommandFlags(cmd, out _), $"Command does not have admin permissions set up: {cmd.FullName()}");
                }
            });
        });
    }
}
