// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Actions.Events;

public sealed class ActionUpgradeEvent : EntityEventArgs
{
    public int NewLevel;
    public EntityUid? ActionId;

    public ActionUpgradeEvent(int newLevel, EntityUid? actionId)
    {
        NewLevel = newLevel;
        ActionId = actionId;
    }
}
