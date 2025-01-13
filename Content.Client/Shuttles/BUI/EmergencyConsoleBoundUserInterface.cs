// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Client.Computer;
using Content.Client.Shuttles.UI;
using Content.Shared.Shuttles.BUIStates;
using JetBrains.Annotations;

namespace Content.Client.Shuttles.BUI;

[UsedImplicitly]
public sealed class EmergencyConsoleBoundUserInterface : ComputerBoundUserInterface<EmergencyConsoleWindow, EmergencyConsoleBoundUserInterfaceState>
{
    public EmergencyConsoleBoundUserInterface(EntityUid owner, Enum uiKey) : base(owner, uiKey)
    {
    }
}
