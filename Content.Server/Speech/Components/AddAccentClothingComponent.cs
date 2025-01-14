// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom.Prototype;

namespace Content.Server.Speech.Components;

/// <summary>
///     Applies accent to user while they wear entity as a clothing.
/// </summary>
[RegisterComponent]
public sealed partial class AddAccentClothingComponent : Component
{
    /// <summary>
    ///     Component name for accent that will be applied.
    /// </summary>
    [DataField("accent", required: true)]
    public string Accent = default!;

    /// <summary>
    ///     What <see cref="ReplacementAccentPrototype"/> to use.
    ///     Will be applied only with <see cref="ReplacementAccentComponent"/>.
    /// </summary>
    [DataField("replacement", customTypeSerializer: typeof(PrototypeIdSerializer<ReplacementAccentPrototype>))]
    public string? ReplacementPrototype;

    /// <summary>
    ///     Is that clothing is worn and affecting someones accent?
    /// </summary>
    public bool IsActive = false;
}
