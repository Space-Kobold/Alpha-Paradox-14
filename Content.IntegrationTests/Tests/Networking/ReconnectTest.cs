// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Client.Console;
using Robust.Shared.Network;

namespace Content.IntegrationTests.Tests.Networking
{
    [TestFixture]
    public sealed class ReconnectTest
    {
        [Test]
        public async Task Test()
        {
            await using var pair = await PoolManager.GetServerClient(new PoolSettings { Connected = true });
            var server = pair.Server;
            var client = pair.Client;

            var host = client.ResolveDependency<IClientConsoleHost>();
            var netManager = client.ResolveDependency<IClientNetManager>();

            await client.WaitPost(() => host.ExecuteCommand("disconnect"));

            // Run some ticks for the disconnect to complete and such.
            await pair.RunTicksSync(5);

            await Task.WhenAll(client.WaitIdleAsync(), server.WaitIdleAsync());

            // Reconnect.
            client.SetConnectTarget(server);

            await client.WaitPost(() => netManager.ClientConnect(null, 0, null));

            // Run some ticks for the handshake to complete and such.
            await pair.RunTicksSync(10);

            await Task.WhenAll(client.WaitIdleAsync(), server.WaitIdleAsync());
            await pair.CleanReturnAsync();
        }
    }
}
