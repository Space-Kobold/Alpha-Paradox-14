// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using System.Collections.Generic;
using Content.Server.Construction;
using Content.Shared.Construction;
using Robust.Shared.GameObjects;

namespace Content.IntegrationTests.Tests.Interaction;

/// <summary>
///     System for listening to events that get raised when construction entities change.
///     In particular, when construction ghosts become real entities, and when existing entities get replaced with
///     new ones.
/// </summary>
public sealed class InteractionTestSystem : EntitySystem
{
    public Dictionary<int, NetEntity> Ghosts = new();
    public Dictionary<NetEntity, NetEntity> EntChanges = new();

    public override void Initialize()
    {
        SubscribeNetworkEvent<AckStructureConstructionMessage>(OnAck);
        SubscribeLocalEvent<ConstructionChangeEntityEvent>(OnEntChange);
    }

    private void OnEntChange(ConstructionChangeEntityEvent ev)
    {
        Assert.That(!IsClientSide(ev.Old) && !IsClientSide(ev.New));
        EntChanges[GetNetEntity(ev.Old)] = GetNetEntity(ev.New);
    }

    private void OnAck(AckStructureConstructionMessage ev)
    {
        if (ev.Uid != null)
            Ghosts[ev.GhostId] = ev.Uid.Value;
    }
}
