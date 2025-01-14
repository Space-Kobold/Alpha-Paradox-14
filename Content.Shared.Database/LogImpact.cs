// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Database;

// DO NOT CHANGE THE NUMERIC VALUES OF THESE
[Serializable]
public enum LogImpact : sbyte
{
    Low = -1,
    Medium = 0,
    High = 1,
    Extreme = 2 // Nar'Sie just dropped
}
