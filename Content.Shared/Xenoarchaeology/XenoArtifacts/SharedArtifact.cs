// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Actions;
using Robust.Shared.Serialization;

namespace Content.Shared.Xenoarchaeology.XenoArtifacts;

[Serializable, NetSerializable]
public enum SharedArtifactsVisuals : byte
{
    SpriteIndex,
    IsActivated
}

/// <summary>
///     Raised as an instant action event when a sentient artifact activates itself using an action.
/// </summary>
public sealed partial class ArtifactSelfActivateEvent : InstantActionEvent
{
}
