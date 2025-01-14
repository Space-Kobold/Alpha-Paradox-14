// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.NPC.HTN;

/// <summary>
/// Helper interface to run the appropriate shutdown for a particular task.
/// </summary>
public interface IHtnConditionalShutdown
{
    /// <summary>
    /// When to shut the task down.
    /// </summary>
    HTNPlanState ShutdownState { get; }

    /// <summary>
    /// Run whenever the <see cref="ShutdownState"/> specifies.
    /// </summary>
    void ConditionalShutdown(NPCBlackboard blackboard);
}
