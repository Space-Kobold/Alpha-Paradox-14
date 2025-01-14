// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.IntegrationTests.Tests.Interaction;

namespace Content.IntegrationTests.Tests.Construction.Interaction;

public sealed class WallConstruction : InteractionTest
{
    public const string Girder = "Girder";
    public const string WallSolid = "WallSolid";
    public const string Wall = "Wall";

    [Test]
    public async Task ConstructWall()
    {
        await StartConstruction(Wall);
        await InteractUsing(Steel, 2);
        Assert.That(Hands.ActiveHandEntity, Is.Null);
        ClientAssertPrototype(Girder, Target);
        await InteractUsing(Steel, 2);
        Assert.That(Hands.ActiveHandEntity, Is.Null);
        AssertPrototype(WallSolid);
    }

    [Test]
    public async Task DeconstructWall()
    {
        await StartDeconstruction(WallSolid);
        await InteractUsing(Weld);
        AssertPrototype(Girder);
        await Interact(Wrench, Screw);
        AssertDeleted();
        await AssertEntityLookup((Steel, 4));
    }
}
