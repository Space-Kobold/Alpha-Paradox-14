// SPDX-FileCopyrightText: 2025 Space Kobold Games and Contributors
// SPDX-License-Identifier: MPL-2.0-no-copyleft-exception

namespace Content.Shared._APCore.Chemistry.Registry.Components;

[RegisterComponent, AutoGenerateComponentState]
public sealed partial class ChemRegistryComponent : Component
{
    [DataField, AutoNetworkedField]
    public bool IsBuilt = false;
    [DataField, AutoNetworkedField]
    public Dictionary<string, ReagentDefinition> Reagents = new();
    [DataField, AutoNetworkedField]
    public Dictionary<string, ReactionDefinition> Reactions = new();
}
