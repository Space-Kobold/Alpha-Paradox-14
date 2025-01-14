// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using System.Text.Json;
using Content.Shared.FixedPoint;

namespace Content.Server.Administration.Logs.Converters;

[AdminLogConverter]
public sealed class FixedPoint2Converter : AdminLogConverter<FixedPoint2>
{
    public override void Write(Utf8JsonWriter writer, FixedPoint2 value, JsonSerializerOptions options)
    {
        writer.WriteNumberValue(value.Int());
    }
}
