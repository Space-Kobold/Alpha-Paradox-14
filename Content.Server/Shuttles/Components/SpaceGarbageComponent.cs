// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.Shuttles.Components;

/// <summary>
///     Cleanup component that deletes the entity if it has a cross-grid collision.
///     Useful for small, unimportant items like bullets to avoid generating many contacts.
/// </summary>
[RegisterComponent]
public sealed partial class SpaceGarbageComponent : Component {}
