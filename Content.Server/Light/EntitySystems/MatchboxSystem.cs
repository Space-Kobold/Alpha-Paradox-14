// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Light.Components;
using Content.Server.Storage.EntitySystems;
using Content.Shared.Interaction;
using Content.Shared.Smoking;

namespace Content.Server.Light.EntitySystems
{
    public sealed class MatchboxSystem : EntitySystem
    {
        [Dependency] private readonly MatchstickSystem _stickSystem = default!;

        public override void Initialize()
        {
            base.Initialize();
            SubscribeLocalEvent<MatchboxComponent, InteractUsingEvent>(OnInteractUsing, before: new[] { typeof(StorageSystem) });
        }

        private void OnInteractUsing(EntityUid uid, MatchboxComponent component, InteractUsingEvent args)
        {
            if (!args.Handled
                && EntityManager.TryGetComponent(args.Used, out MatchstickComponent? matchstick)
                && matchstick.CurrentState == SmokableState.Unlit)
            {
                _stickSystem.Ignite((args.Used, matchstick), args.User);
                args.Handled = true;
            }
        }
    }
}
