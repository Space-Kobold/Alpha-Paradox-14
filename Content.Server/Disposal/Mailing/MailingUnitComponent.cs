// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Disposal.Components;

namespace Content.Server.Disposal.Mailing;

[Access(typeof(MailingUnitSystem))]
[RegisterComponent]
public sealed partial class MailingUnitComponent : Component
{
    /// <summary>
    /// List of targets the mailing unit can send to.
    /// Each target is just a disposal routing tag
    /// </summary>
    [DataField("targetList")]
    public List<string> TargetList = new();

    /// <summary>
    /// The target that gets attached to the disposal holders tag list on flush
    /// </summary>
    [DataField("target")]
    public string? Target;

    /// <summary>
    /// The tag for this mailing unit
    /// </summary>
    [ViewVariables(VVAccess.ReadWrite)]
    [DataField("tag")]
    public string? Tag;

    public SharedDisposalUnitComponent.DisposalUnitBoundUserInterfaceState? DisposalUnitInterfaceState;
}
