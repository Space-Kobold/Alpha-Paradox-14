// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Client.Weapons.Ranged.Systems;

namespace Content.Client.Weapons.Ranged.Components;

[RegisterComponent, Access(typeof(GunSystem))]
public sealed partial class SpentAmmoVisualsComponent : Component
{
    /// <summary>
    /// Should we do "{_state}-spent" or just "spent"
    /// </summary>
    [DataField("suffix")] public bool Suffix = true;

    [DataField("state")]
    public string State = "base";
}

public enum AmmoVisualLayers : byte
{
    Base,
    Tip,
}
