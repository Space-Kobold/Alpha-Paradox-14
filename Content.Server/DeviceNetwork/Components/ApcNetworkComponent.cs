// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.DeviceNetwork.Systems;
using Content.Server.NodeContainer.Nodes;

namespace Content.Server.DeviceNetwork.Components
{
    [RegisterComponent]
    [Access(typeof(ApcNetworkSystem))]
    [ComponentProtoName("ApcNetworkConnection")]
    public sealed partial class ApcNetworkComponent : Component
    {
        /// <summary>
        /// The node Group the ApcNetworkConnection is connected to
        /// </summary>
        [ViewVariables] public Node? ConnectedNode;
    }
}
