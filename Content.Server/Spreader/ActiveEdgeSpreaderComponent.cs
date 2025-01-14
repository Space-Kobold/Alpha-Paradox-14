// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.Spreader;

/// <summary>
/// Added to entities being considered for spreading via <see cref="SpreaderSystem"/>.
/// This needs to be manually added and removed.
/// </summary>
[RegisterComponent]
public sealed partial class ActiveEdgeSpreaderComponent : Component
{
}
