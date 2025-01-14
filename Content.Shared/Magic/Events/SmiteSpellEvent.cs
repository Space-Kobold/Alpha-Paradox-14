// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Actions;

namespace Content.Shared.Magic.Events;

public sealed partial class SmiteSpellEvent : EntityTargetActionEvent, ISpeakSpell
{
    // TODO: Make part of gib method
    /// <summary>
    /// Should this smite delete all parts/mechanisms gibbed except for the brain?
    /// </summary>
    [DataField]
    public bool DeleteNonBrainParts = true;

    [DataField]
    public string? Speech { get; private set; }
}
