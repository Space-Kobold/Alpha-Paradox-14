// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Humanoid.Prototypes;
using Robust.Shared.Prototypes;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom.Prototype;

namespace Content.Server.Humanoid.Components;

/// <summary>
///     This is added to a marker entity in order to spawn a randomized
///     humanoid ingame.
/// </summary>
[RegisterComponent, EntityCategory("Spawner")]
public sealed partial class RandomHumanoidSpawnerComponent : Component
{
    [DataField("settings", customTypeSerializer: typeof(PrototypeIdSerializer<RandomHumanoidSettingsPrototype>))]
    public string? SettingsPrototypeId;
}
