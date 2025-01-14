// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.RandomMetadata;

/// <summary>
///     Randomizes the description and/or the name for an entity by creating it from list of dataset prototypes or strings.
/// </summary>
[RegisterComponent]
public sealed partial class RandomMetadataComponent : Component
{
    [DataField("descriptionSegments")]
    public List<string>? DescriptionSegments;

    [DataField("nameSegments")]
    public List<string>? NameSegments;

    [DataField("nameSeparator")]
    public string NameSeparator = " ";

    [DataField("descriptionSeparator")]
    public string DescriptionSeparator = " ";
}
