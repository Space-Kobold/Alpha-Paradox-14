// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Audio;

namespace Content.Server.Storage.Components;

[RegisterComponent]
public sealed partial class CursedEntityStorageComponent : Component
{
    [DataField("cursedSound")]
    public SoundSpecifier CursedSound = new SoundPathSpecifier("/Audio/Effects/teleport_departure.ogg");
}
