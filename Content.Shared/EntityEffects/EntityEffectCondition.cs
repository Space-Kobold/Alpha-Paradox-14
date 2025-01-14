// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using System.Text.Json.Serialization;
using JetBrains.Annotations;
using Robust.Shared.Prototypes;

namespace Content.Shared.EntityEffects;

[ImplicitDataDefinitionForInheritors]
[MeansImplicitUse]
public abstract partial class EntityEffectCondition
{
    [JsonPropertyName("id")] private protected string _id => this.GetType().Name;

    public abstract bool Condition(EntityEffectBaseArgs args);

    /// <summary>
    /// Effect explanations are of the form "[chance to] [action] when [condition] and [condition]"
    /// </summary>
    /// <param name="prototype"></param>
    /// <returns></returns>
    public abstract string GuidebookExplanation(IPrototypeManager prototype);
}

