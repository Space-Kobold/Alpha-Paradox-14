// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Serialization;

namespace Content.Shared.Labels;

/// <summary>
/// Key representing which <see cref="PlayerBoundUserInterface"/> is currently open.
/// Useful when there are multiple UI for an object. Here it's future-proofing only.
/// </summary>
[Serializable, NetSerializable]
public enum HandLabelerUiKey
{
    Key,
}

[Serializable, NetSerializable]
public enum PaperLabelVisuals : byte
{
    Layer,
    HasLabel,
    LabelType
}

[Serializable, NetSerializable]
public sealed class HandLabelerLabelChangedMessage(string label) : BoundUserInterfaceMessage
{
    public string Label { get; } = label;
}
