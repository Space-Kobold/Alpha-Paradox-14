// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.NodeContainer.Nodes
{
    /// <summary>
    ///     A <see cref="Node"/> that implements this will have its <see cref="RotateNode(MoveEvent)"/> called when its
    ///     <see cref="NodeContainerComponent"/> is rotated.
    /// </summary>
    public interface IRotatableNode
    {
        /// <summary>
        ///     Rotates this <see cref="Node"/>. Returns true if the node's connections need to be updated.
        /// </summary>
        bool RotateNode(in MoveEvent ev);
    }
}
