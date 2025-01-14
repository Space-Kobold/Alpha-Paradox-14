// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Serialization;

namespace Content.Shared.Cargo;

[NetSerializable, Serializable]
public enum CargoConsoleUiKey : byte
{
    Orders,
    Bounty,
    Shuttle,
    Telepad
}

[NetSerializable, Serializable]
public enum CargoPalletConsoleUiKey : byte
{
    Sale
}

public abstract class SharedCargoSystem : EntitySystem {}

[Serializable, NetSerializable]
public enum CargoTelepadState : byte
{
    Unpowered,
    Idle,
    Teleporting,
};

[Serializable, NetSerializable]
public enum CargoTelepadVisuals : byte
{
    State,
};
