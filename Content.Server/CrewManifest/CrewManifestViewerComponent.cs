// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.CCVar;

namespace Content.Server.CrewManifest;

[RegisterComponent]
public sealed partial class CrewManifestViewerComponent : Component
{
    /// <summary>
    ///     If this manifest viewer is unsecure or not. If it is,
    ///     <see cref="CCVars.CrewManifestUnsecure"/> being false will
    ///     not allow this entity to be processed by CrewManifestSystem.
    /// </summary>
    [DataField("unsecure")] public bool Unsecure;

    /// <summary>
    /// The owner interface of this crew manifest viewer. When it closes, so too will an opened crew manifest.
    /// </summary>
    [DataField(required: true)]
    public Enum OwnerKey { get; private set; } = default!;
}
