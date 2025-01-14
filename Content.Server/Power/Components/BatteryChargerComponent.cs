// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Power.NodeGroups;

namespace Content.Server.Power.Components
{
    /// <summary>
    ///     Connects the loading side of a <see cref="BatteryComponent"/> to a non-APC power network.
    /// </summary>
    [RegisterComponent]
    public sealed partial class BatteryChargerComponent : BasePowerNetComponent
    {
        protected override void AddSelfToNet(IPowerNet net)
        {
            net.AddCharger(this);
        }

        protected override void RemoveSelfFromNet(IPowerNet net)
        {
            net.RemoveCharger(this);
        }
    }
}
