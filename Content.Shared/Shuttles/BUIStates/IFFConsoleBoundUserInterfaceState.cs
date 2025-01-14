// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Shuttles.Components;
using Robust.Shared.Serialization;

namespace Content.Shared.Shuttles.BUIStates;

[Serializable, NetSerializable]
public sealed class IFFConsoleBoundUserInterfaceState : BoundUserInterfaceState
{
    public IFFFlags AllowedFlags;
    public IFFFlags Flags;
}

[Serializable, NetSerializable]
public enum IFFConsoleUiKey : byte
{
    Key,
}
