// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;
using Robust.Shared.Serialization;

namespace Content.Shared.Salvage.Expeditions;

[NetworkedComponent]
public abstract partial class SharedSalvageExpeditionComponent : Component
{
    [ViewVariables(VVAccess.ReadWrite), DataField("stage")]
    public ExpeditionStage Stage = ExpeditionStage.Added;
}

[Serializable, NetSerializable]
public sealed class SalvageExpeditionComponentState : ComponentState
{
    public ExpeditionStage Stage;
}
