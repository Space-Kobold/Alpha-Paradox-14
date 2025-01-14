// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.EUI;
using Content.Shared.Eui;
using Content.Shared.Ghost;
using Content.Shared.Mind;

namespace Content.Server.Ghost;

public sealed class ReturnToBodyEui : BaseEui
{
    private readonly SharedMindSystem _mindSystem;

    private readonly MindComponent _mind;

    public ReturnToBodyEui(MindComponent mind, SharedMindSystem mindSystem)
    {
        _mind = mind;
        _mindSystem = mindSystem;
    }

    public override void HandleMessage(EuiMessageBase msg)
    {
        base.HandleMessage(msg);

        if (msg is not ReturnToBodyMessage choice ||
            !choice.Accepted)
        {
            Close();
            return;
        }

        _mindSystem.UnVisit(_mind.Session);

        Close();
    }
}
