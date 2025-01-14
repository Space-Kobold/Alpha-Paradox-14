// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Paper;
using Content.Shared.StoryGen;
using Robust.Shared.Prototypes;

namespace Content.Server.Paper;

/// <summary>
///    Adds a randomly generated story to the content of a <see cref="PaperComponent"/>
/// </summary>
[RegisterComponent, Access(typeof(PaperRandomStorySystem))]
public sealed partial class PaperRandomStoryComponent : Component
{
    /// <summary>
    /// The <see cref="StoryTemplatePrototype"/> ID to use for story generation.
    /// </summary>
    [DataField]
    public ProtoId<StoryTemplatePrototype> Template;
}
