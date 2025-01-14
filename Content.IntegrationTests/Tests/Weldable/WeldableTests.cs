// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.IntegrationTests.Tests.Interaction;
using Content.Shared.Tools.Components;

namespace Content.IntegrationTests.Tests.Weldable;

/// <summary>
///  Simple test to check that using a welder on a locker will weld it shut.
/// </summary>
public sealed class WeldableTests : InteractionTest
{
    public const string Locker = "LockerFreezer";

    [Test]
    public async Task WeldLocker()
    {
        await SpawnTarget(Locker);
        var comp = Comp<WeldableComponent>();

        Assert.That(comp.IsWelded, Is.False);

        await InteractUsing(Weld);
        Assert.That(comp.IsWelded, Is.True);
        AssertPrototype(Locker); // Prototype did not change.
    }
}
