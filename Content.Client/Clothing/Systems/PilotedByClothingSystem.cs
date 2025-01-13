// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Clothing.Components;
using Robust.Client.Physics;

namespace Content.Client.Clothing.Systems;

public sealed partial class PilotedByClothingSystem : EntitySystem
{
    public override void Initialize()
    {
        base.Initialize();

        SubscribeLocalEvent<PilotedByClothingComponent, UpdateIsPredictedEvent>(OnUpdatePredicted);
    }

    private void OnUpdatePredicted(Entity<PilotedByClothingComponent> entity, ref UpdateIsPredictedEvent args)
    {
        args.BlockPrediction = true;
    }
}
