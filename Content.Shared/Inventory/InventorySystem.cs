// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Hands.Components;

namespace Content.Shared.Inventory;

public partial class InventorySystem
{

    public override void Initialize()
    {
        base.Initialize();
        InitializeEquip();
        InitializeRelay();
        InitializeSlots();
    }

    public override void Shutdown()
    {
        base.Shutdown();
        ShutdownSlots();
    }
}
