// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Random;

/// <summary>
/// Budgeted random spawn entry.
/// </summary>
public interface IBudgetEntry : IProbEntry
{
    float Cost { get; set; }

    string Proto { get; set; }
}

/// <summary>
/// Random entry that has a prob. See <see cref="RandomSystem"/>
/// </summary>
public interface IProbEntry
{
    float Prob { get; set; }
}

