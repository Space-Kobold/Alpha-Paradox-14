// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Radio.Components;

namespace Content.Shared.Radio;

public sealed class EncryptionChannelsChangedEvent : EntityEventArgs
{
    public readonly EncryptionKeyHolderComponent Component;

    public EncryptionChannelsChangedEvent(EncryptionKeyHolderComponent component)
    {
        Component = component;
    }
}
