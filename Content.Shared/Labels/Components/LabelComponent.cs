// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;

namespace Content.Shared.Labels.Components;

/// <summary>
/// Makes entities have a label in their name. Labels are normally given by <see cref="HandLabelerComponent"/>
/// </summary>
[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
public sealed partial class LabelComponent : Component
{
    /// <summary>
    /// Current text on the label. If set before map init, during map init this string will be localized.
    /// This permits localized preset labels with fallback to the text written on the label.
    /// </summary>
    [DataField, AutoNetworkedField]
    public string? CurrentLabel { get; set; }
}
