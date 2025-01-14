// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using System.Diagnostics.CodeAnalysis;
using Content.Server.NodeContainer.Nodes;

namespace Content.Server.NodeContainer
{
    /// <summary>
    ///     Creates and maintains a set of <see cref="Node"/>s.
    /// </summary>
    [RegisterComponent]
    public sealed partial class NodeContainerComponent : Component
    {
        //HACK: THIS BEING readOnly IS A FILTHY HACK AND I HATE IT --moony
        [DataField("nodes", readOnly: true)] public Dictionary<string, Node> Nodes { get; private set; } = new();

        [DataField("examinable")] public bool Examinable = false;
    }
}
