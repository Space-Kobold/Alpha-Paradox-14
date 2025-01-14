// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Actions;

namespace Content.Shared.Magic.Events;

public sealed partial class KnockSpellEvent : InstantActionEvent, ISpeakSpell
{
    /// <summary>
    /// The range this spell opens doors in
    /// 10f is the default
    /// Should be able to open all doors/lockers in visible sight
    /// </summary>
    [DataField]
    public float Range = 10f;

    [DataField]
    public string? Speech { get; private set; }
}
