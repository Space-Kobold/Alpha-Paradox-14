// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using System.IO;
using System.Linq;
using System.Text.Json;
using Content.Shared.Chemistry.Reaction;
using Content.Shared.EntityEffects;
using Robust.Shared.Prototypes;

namespace Content.Server.GuideGenerator;

public sealed class ReactionJsonGenerator
{
    public static void PublishJson(StreamWriter file)
    {
        var prototype = IoCManager.Resolve<IPrototypeManager>();

        var reactions =
            prototype
                .EnumeratePrototypes<ReactionPrototype>()
                .Select(x => new ReactionEntry(x))
                .ToDictionary(x => x.Id, x => x);

        var serializeOptions = new JsonSerializerOptions
        {
            WriteIndented = true,
            Converters =
            {
                new UniversalJsonConverter<EntityEffect>(),
            }
        };

        file.Write(JsonSerializer.Serialize(reactions, serializeOptions));
    }
}

