// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.NPC.HTN.Preconditions;

/// <summary>
/// Checks for the presence of the value by the specified <see cref="KeyExistsPrecondition.Key"/> in the <see cref="NPCBlackboard"/>.
/// Returns true if there is a value.
/// </summary>
public sealed partial class KeyExistsPrecondition : HTNPrecondition
{
    [DataField(required: true), ViewVariables]
    public string Key = string.Empty;

    public override bool IsMet(NPCBlackboard blackboard)
    {
        return blackboard.ContainsKey(Key);
    }
}
