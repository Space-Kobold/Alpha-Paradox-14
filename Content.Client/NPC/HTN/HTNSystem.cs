// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.NPC;
using Robust.Client.Graphics;
using Robust.Client.ResourceManagement;

namespace Content.Client.NPC.HTN;

public sealed class HTNSystem : EntitySystem
{
    /*
     * Mainly handles clientside debugging for HTN NPCs.
     */
    public bool EnableOverlay
    {
        get => _enableOverlay;
        set
        {
            var overlayManager = IoCManager.Resolve<IOverlayManager>();
            _enableOverlay = value;

            if (_enableOverlay)
            {
                overlayManager.AddOverlay(new HTNOverlay(EntityManager, IoCManager.Resolve<IResourceCache>()));
                RaiseNetworkEvent(new RequestHTNMessage()
                {
                    Enabled = true,
                });
            }
            else
            {
                overlayManager.RemoveOverlay<HTNOverlay>();
                RaiseNetworkEvent(new RequestHTNMessage()
                {
                    Enabled = false,
                });
            }
        }
    }

    private bool _enableOverlay;

    public override void Initialize()
    {
        base.Initialize();
        SubscribeNetworkEvent<HTNMessage>(OnHTNMessage);
    }

    private void OnHTNMessage(HTNMessage ev)
    {
        if (!TryComp<HTNComponent>(GetEntity(ev.Uid), out var htn))
            return;

        htn.DebugText = ev.Text;
    }
}
