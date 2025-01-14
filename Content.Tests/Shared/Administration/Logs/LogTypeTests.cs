// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using System;
using System.Linq;
using Content.Shared.Database;
using NUnit.Framework;

namespace Content.Tests.Shared.Administration.Logs;

[TestFixture]
public sealed class LogTypeTests
{
    [Test]
    public void Unique()
    {
        var types = Enum.GetValues<LogType>();
        var duplicates = types
            .GroupBy(x => x)
            .Where(g => g.Count() > 1)
            .Select(g => g.Key)
            .ToArray();

        Assert.That(duplicates.Length, Is.Zero, $"{nameof(LogType)} has duplicate values for: " + string.Join(", ", duplicates));
    }
}
