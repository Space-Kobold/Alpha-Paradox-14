// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.DoAfter;
using Robust.Shared.Serialization;

namespace Content.Shared.Exchanger;

[Serializable, NetSerializable]
public sealed partial class ExchangerDoAfterEvent : SimpleDoAfterEvent
{
}
