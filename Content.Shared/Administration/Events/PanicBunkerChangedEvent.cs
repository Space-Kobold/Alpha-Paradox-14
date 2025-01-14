// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Serialization;

namespace Content.Shared.Administration.Events;

[Serializable, NetSerializable]
public sealed class PanicBunkerStatus
{
    public bool Enabled;
    public bool DisableWithAdmins;
    public bool EnableWithoutAdmins;
    public bool CountDeadminnedAdmins;
    public bool ShowReason;
    public int MinAccountAgeMinutes;
    public int MinOverallMinutes;
}

[Serializable, NetSerializable]
public sealed class PanicBunkerChangedEvent : EntityEventArgs
{
    public PanicBunkerStatus Status;

    public PanicBunkerChangedEvent(PanicBunkerStatus status)
    {
        Status = status;
    }
}
