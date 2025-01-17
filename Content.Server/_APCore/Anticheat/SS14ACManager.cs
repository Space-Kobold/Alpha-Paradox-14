// ***
// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
// If a copy of the MPL was not distributed with this file, You can obtain one at https://mozilla.org/MPL/2.0/.
// This Source Code Form is "Incompatible With Secondary Licenses", as defined by the Mozilla Public License, v. 2.0.
// ***

using System.Linq;
using Content.Server.Administration.Logs;
using Content.Server.Administration.Managers;
using Content.Server.Chat.Managers;
using Content.Shared._APCore.Anticheat;
using Content.Shared.Database;
using Robust.Server.Player;
using Robust.Shared.Configuration;
using Robust.Shared.Enums;
using Robust.Shared.Network;
using Robust.Shared.Player;

namespace Content.Server._APCore.Anticheat;

public sealed class SS14ACManager : IPostInjectInit
{
    private static readonly string[] WhitelistedModules =
    [
        "Content.Client", "Content.Shared", "Content.Shared.Database",
        "Robust.Client", "Robust.Shared",
    ];

    [Dependency] private readonly ILogManager _logger = default!;
    [Dependency] private readonly INetManager _netMan = default!;
    [Dependency] private readonly IChatManager _chat = default!;
    [Dependency] private readonly IBanManager _ban = default!;
    [Dependency] private readonly IConfigurationManager _configuration = default!;
    [Dependency] private readonly IAdminLogManager _adminLog = default!;
    [Dependency] private readonly IPlayerManager _playMan = default!;

    private ISawmill _saw = default!;
    private bool _enabled;

    public void PostInject()
    {
        _saw = _logger.GetSawmill("SS14AC");

        _configuration.OnValueChanged(SS14ACCvars.Enabled, value => _enabled = value, true);

        _playMan.PlayerStatusChanged += Check;

        RegisterNetMessages();
    }

    private void Check(object? sender, SessionStatusEventArgs e)
    {
        if (e.NewStatus == SessionStatus.Connected)
            Check(e.Session.Channel);
    }

    private void Check(INetChannel chan)
    {
        _netMan.ServerSendMessage(new ACReflectionCheckReqMsg(), chan);
    }

    private void RegisterNetMessages()
    {
        _netMan.RegisterNetMessage<ACReflectionCheckReqMsg>();
        _netMan.RegisterNetMessage<ACReflectionCheckRepMsg>(OnAntiCheatReflectionCheck);
    }

    private void OnAntiCheatReflectionCheck(ACReflectionCheckRepMsg repMsg)
    {
        if (!_enabled)
            return;

        foreach (var module in repMsg.Modules)
        {
            if (WhitelistedModules.Contains(module))
                continue;

            _saw.Debug($"{repMsg.MsgChannel.UserName} failed anticheat check!");
            Action(repMsg.MsgChannel, module);
            return;
        }
    }

    private void Action(INetChannel netChannel, string modulename)
    {
        var msg = Loc.GetString("SS14AC-Failed-Reflection", ("player", netChannel.UserName), ("module", modulename));

        _chat.SendAdminAlert(msg);
                                                // This is definitely me when LogStringHandler
        _adminLog.Add(LogType.SS14AC, LogImpact.Extreme, $"{msg}");

        if (_configuration.GetCVar(SS14ACCvars.BanOnCheckFailure))
            _ban.CreateServerBan(netChannel.UserId, null, null, null, null, null, NoteSeverity.High, reason: "SS14AC: Reflection check failed");
    }
}
