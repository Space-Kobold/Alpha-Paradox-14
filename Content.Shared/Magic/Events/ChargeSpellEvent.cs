// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Actions;

namespace Content.Shared.Magic.Events;

/// <summary>
/// Adds provided Charge to the held wand
/// </summary>
public sealed partial class ChargeSpellEvent : InstantActionEvent, ISpeakSpell
{
    [DataField(required: true)]
    public int Charge;

    [DataField]
    public string WandTag = "WizardWand";

    [DataField]
    public string? Speech { get; private set; }
}
