// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Objectives.Components;
using Robust.Shared.Serialization;
using Robust.Shared.Utility;

namespace Content.Shared.Objectives;

/// <summary>
/// Info about objectives visible in the character menu and on round end.
/// Description and icon are displayed only in the character menu.
/// Progress is a percentage from 0.0 to 1.0.
/// </summary>
/// <remarks>
/// All of these fields must eventually be set by condition event handlers.
/// Everything but progress can be set to static data in yaml on the entity and <see cref="ObjectiveComponent"/>.
/// If anything is null it will be logged and return null.
/// </remarks>
[Serializable, NetSerializable]
public record struct ObjectiveInfo(string Title, string Description, SpriteSpecifier Icon, float Progress);
