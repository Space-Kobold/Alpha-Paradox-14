// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Client.UserInterface;
using Robust.Client.UserInterface.Controls;
using Robust.Shared.Utility;
using System.Diagnostics.CodeAnalysis;

namespace Content.Client.Guidebook.Richtext;

/// <summary>
/// A document, containing arbitrary text and UI elements.
/// </summary>
public sealed class Document : BoxContainer, IDocumentTag
{
    public Document()
    {
        Orientation = LayoutOrientation.Vertical;
    }

    public bool TryParseTag(Dictionary<string, string> args, [NotNullWhen(true)] out Control? control)
    {
        DebugTools.Assert(args.Count == 0);
        control = this;
        return true;
    }
}

public interface IDocumentTag
{
    public bool TryParseTag(Dictionary<string, string> args, [NotNullWhen(true)] out Control? control);
}
