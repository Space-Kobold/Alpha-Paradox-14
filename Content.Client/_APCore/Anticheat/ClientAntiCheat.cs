// ***
// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
// If a copy of the MPL was not distributed with this file, You can obtain one at https://mozilla.org/MPL/2.0/.
// This Source Code Form is "Incompatible With Secondary Licenses", as defined by the Mozilla Public License, v. 2.0.
// ***

using Content.Shared._APCore.Anticheat;
using Robust.Client.Player;
using Robust.Client.Timing;
using Robust.Client.UserInterface.Controls;
using Robust.Shared.Network;
using Robust.Shared.Player;
using Robust.Shared.Reflection;

namespace Content.Client._APCore.Anticheat;

public sealed class SS14AC : IPostInjectInit
{
    [Dependency] private readonly INetManager _netMan = default!;
    [Dependency] private readonly IReflectionManager _reflection = default!;

    public void PostInject()
    {
        _netMan.RegisterNetMessage<ACReflectionCheckReqMsg>(CollectExtraModules);
        _netMan.RegisterNetMessage<ACReflectionCheckRepMsg>();
    }

    private void CollectExtraModules(ACReflectionCheckReqMsg req)
    {
        var modules = _reflection.Assemblies;
        List<string> moduleNames = [];

        foreach (var module in modules)
        {
            var name = module.GetName().Name;

            if (name != null)
                moduleNames.Add(name);
        }

        var msg = new ACReflectionCheckRepMsg
        {
            Modules = moduleNames
        };

        _netMan.ClientSendMessage(msg);
    }
}
