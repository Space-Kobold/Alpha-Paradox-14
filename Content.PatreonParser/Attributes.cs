// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using System.Text.Json.Serialization;

namespace Content.PatreonParser;

public sealed class Attributes
{
    [JsonPropertyName("full_name")]
    public string FullName = default!;

    [JsonPropertyName("pledge_relationship_start")]
    public DateTime? PledgeRelationshipStart;

    [JsonPropertyName("title")]
    public string Title = default!;
}
