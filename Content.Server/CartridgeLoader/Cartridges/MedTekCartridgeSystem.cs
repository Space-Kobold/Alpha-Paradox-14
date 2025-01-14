// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Medical.Components;
using Content.Shared.CartridgeLoader;

namespace Content.Server.CartridgeLoader.Cartridges;

public sealed class MedTekCartridgeSystem : EntitySystem
{
    [Dependency] private readonly CartridgeLoaderSystem _cartridgeLoaderSystem = default!;

    public override void Initialize()
    {
        base.Initialize();

        SubscribeLocalEvent<MedTekCartridgeComponent, CartridgeAddedEvent>(OnCartridgeAdded);
        SubscribeLocalEvent<MedTekCartridgeComponent, CartridgeRemovedEvent>(OnCartridgeRemoved);
    }

    private void OnCartridgeAdded(Entity<MedTekCartridgeComponent> ent, ref CartridgeAddedEvent args)
    {
        var healthAnalyzer = EnsureComp<HealthAnalyzerComponent>(args.Loader);
    }

    private void OnCartridgeRemoved(Entity<MedTekCartridgeComponent> ent, ref CartridgeRemovedEvent args)
    {
        // only remove when the program itself is removed
        if (!_cartridgeLoaderSystem.HasProgram<MedTekCartridgeComponent>(args.Loader))
        {
            RemComp<HealthAnalyzerComponent>(args.Loader);
        }
    }
}
