// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Antag;
using Content.Shared.Objectives.Components;
using Robust.Shared.Prototypes;

namespace Content.Server.Antag.Components;

/// <summary>
/// Gives antags selected by this rule a fixed list of objectives.
/// </summary>
[RegisterComponent, Access(typeof(AntagObjectivesSystem))]
public sealed partial class AntagObjectivesComponent : Component
{
    /// <summary>
    /// List of static objectives to give.
    /// </summary>
    [DataField(required: true)]
    public List<EntProtoId<ObjectiveComponent>> Objectives = new();
}
