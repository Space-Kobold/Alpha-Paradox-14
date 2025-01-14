// SPDX-FileCopyrightText: 2025 Space Kobold Games and Contributors
// SPDX-License-Identifier: MPL-2.0-no-copyleft-exception
namespace Content.Shared._APCore.Chemistry.Registry.Components;

[RegisterComponent]
public sealed partial class ReagentDefinitionComponent : Component
{
    [IncludeDataField]
    public ReagentDefinition Definition;
}
