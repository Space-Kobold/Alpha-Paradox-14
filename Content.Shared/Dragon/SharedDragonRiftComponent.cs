// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;
using Robust.Shared.Prototypes;
using Robust.Shared.Serialization;

namespace Content.Shared.Dragon;

[NetworkedComponent, EntityCategory("Spawner")]
public abstract partial class SharedDragonRiftComponent : Component
{
    [DataField("state")]
    public DragonRiftState State = DragonRiftState.Charging;
}

[Serializable, NetSerializable]
public enum DragonRiftState : byte
{
    Charging,
    AlmostFinished,
    Finished,
}
