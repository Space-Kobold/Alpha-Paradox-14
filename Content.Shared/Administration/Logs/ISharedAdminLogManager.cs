// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Database;

namespace Content.Shared.Administration.Logs;

public interface ISharedAdminLogManager
{
    void Add(LogType type, LogImpact impact, ref LogStringHandler handler);

    void Add(LogType type, ref LogStringHandler handler);
}
