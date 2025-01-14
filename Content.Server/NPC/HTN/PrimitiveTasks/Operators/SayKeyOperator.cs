// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Chat.Systems;

namespace Content.Server.NPC.HTN.PrimitiveTasks.Operators;

public sealed partial class SayKeyOperator : HTNOperator
{
    [Dependency] private readonly IEntityManager _entManager = default!;

    private ChatSystem _chat = default!;

    [DataField(required: true)]
    public string Key = string.Empty;

    /// <summary>
    /// Whether to hide message from chat window and logs.
    /// </summary>
    [DataField]
    public bool Hidden;

    public override void Initialize(IEntitySystemManager sysManager)
    {
        base.Initialize(sysManager);

        _chat = sysManager.GetEntitySystem<ChatSystem>();
    }

    public override HTNOperatorStatus Update(NPCBlackboard blackboard, float frameTime)
    {
        if (!blackboard.TryGetValue<object>(Key, out var value, _entManager))
            return HTNOperatorStatus.Failed;

        var @string = value.ToString();
        if (@string is not { })
            return HTNOperatorStatus.Failed;

        var speaker = blackboard.GetValue<EntityUid>(NPCBlackboard.Owner);
        _chat.TrySendInGameICMessage(speaker, @string, InGameICChatType.Speak, hideChat: Hidden, hideLog: Hidden);

        return base.Update(blackboard, frameTime);
    }
}
