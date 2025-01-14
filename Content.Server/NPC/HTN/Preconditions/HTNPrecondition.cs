// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.NPC.HTN.Preconditions;

/// <summary>
/// Condition that needs to be true for a particular primitive task or compound task branch.
/// </summary>
[ImplicitDataDefinitionForInheritors]
public abstract partial class HTNPrecondition
{
    /// <summary>
    /// Handles one-time initialization of this precondition.
    /// </summary>
    /// <param name="sysManager"></param>
    public virtual void Initialize(IEntitySystemManager sysManager)
    {
        IoCManager.InjectDependencies(this);
    }

    /// <summary>
    /// Has this precondition been met for planning purposes?
    /// </summary>
    public abstract bool IsMet(NPCBlackboard blackboard);
}
