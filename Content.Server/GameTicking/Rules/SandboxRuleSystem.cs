// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.GameTicking.Rules.Components;
using Content.Server.Sandbox;
using Content.Shared.GameTicking.Components;

namespace Content.Server.GameTicking.Rules;

public sealed class SandboxRuleSystem : GameRuleSystem<SandboxRuleComponent>
{
    [Dependency] private readonly SandboxSystem _sandbox = default!;

    protected override void Started(EntityUid uid, SandboxRuleComponent component, GameRuleComponent gameRule, GameRuleStartedEvent args)
    {
        base.Started(uid, component, gameRule, args);
        _sandbox.IsSandboxEnabled = true;
    }

    protected override void Ended(EntityUid uid, SandboxRuleComponent component, GameRuleComponent gameRule, GameRuleEndedEvent args)
    {
        base.Ended(uid, component, gameRule, args);
        _sandbox.IsSandboxEnabled = false;
    }
}
