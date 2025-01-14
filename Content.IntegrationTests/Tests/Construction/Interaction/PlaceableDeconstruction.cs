// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.IntegrationTests.Tests.Interaction;
using Content.Shared.Placeable;

namespace Content.IntegrationTests.Tests.Construction.Interaction;

public sealed class PlaceableDeconstruction : InteractionTest
{
    /// <summary>
    /// Checks that you can deconstruct placeable surfaces (i.e., placing a wrench on a table does not take priority).
    /// </summary>
    [Test]
    public async Task DeconstructTable()
    {
        await StartDeconstruction("Table");
        Assert.That(Comp<PlaceableSurfaceComponent>().IsPlaceable);
        await InteractUsing(Wrench);
        AssertPrototype("TableFrame");
        await InteractUsing(Wrench);
        AssertDeleted();
        await AssertEntityLookup((Steel, 1), (Rod, 2));
    }
}

