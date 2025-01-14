// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Guidebook;

/// <summary>
/// Indicates that GuidebookDataSystem should include this field/property when
/// scanning entity prototypes for values to extract.
/// </summary>
/// <remarks>
/// Note that this will not work for client-only components, because the data extraction
/// is done on the server (it uses reflection, which is blocked by the sandbox on clients).
/// </remarks>
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
public sealed class GuidebookDataAttribute : Attribute { }
