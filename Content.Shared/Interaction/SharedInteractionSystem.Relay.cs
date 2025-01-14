// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Interaction.Components;

namespace Content.Shared.Interaction;

public abstract partial class SharedInteractionSystem
{
    public void SetRelay(EntityUid uid, EntityUid? relayEntity, InteractionRelayComponent? component = null)
    {
        if (!Resolve(uid, ref component))
            return;

        component.RelayEntity = relayEntity;
        Dirty(uid, component);
    }
}
