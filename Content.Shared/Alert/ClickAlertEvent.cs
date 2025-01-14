// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Prototypes;
using Robust.Shared.Serialization;

namespace Content.Shared.Alert;

/// <summary>
/// A message that calls the click interaction on a alert
/// </summary>
[Serializable, NetSerializable]
public sealed class ClickAlertEvent : EntityEventArgs
{
    public readonly ProtoId<AlertPrototype> Type;

    public ClickAlertEvent(ProtoId<AlertPrototype> alertType)
    {
        Type = alertType;
    }
}
