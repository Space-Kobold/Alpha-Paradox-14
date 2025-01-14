// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using System.Text.Json.Serialization;

namespace Content.Server.Discord;

public struct WebhookMentions
{
    [JsonPropertyName("parse")]
    public HashSet<string> Parse { get; set; } = new();

    public WebhookMentions()
    {
    }

    public void AllowRoleMentions()
    {
        Parse.Add("roles");
    }
}
