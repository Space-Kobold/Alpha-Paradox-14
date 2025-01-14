// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using JetBrains.Annotations;

namespace Content.IntegrationTests;

/// <summary>
/// Attribute that indicates that a string contains yaml prototype data that should be loaded by integration tests.
/// </summary>
[AttributeUsage(AttributeTargets.Field)]
[MeansImplicitUse]
public sealed class TestPrototypesAttribute : Attribute
{
}
