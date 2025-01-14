// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Popups;

namespace Content.Shared.UserInterface;

/// <summary>
/// <see cref="ActivatableUIRequiresAnchorComponent"/>
/// </summary>
public sealed class ActivatableUIRequiresAnchorSystem : EntitySystem
{
    [Dependency] private readonly SharedPopupSystem _popup = default!;

    public override void Initialize()
    {
        base.Initialize();
        SubscribeLocalEvent<ActivatableUIRequiresAnchorComponent, ActivatableUIOpenAttemptEvent>(OnActivatableUIOpenAttempt);
        SubscribeLocalEvent<ActivatableUIRequiresAnchorComponent, BoundUserInterfaceCheckRangeEvent>(OnUICheck);
    }

    private void OnUICheck(Entity<ActivatableUIRequiresAnchorComponent> ent, ref BoundUserInterfaceCheckRangeEvent args)
    {
        if (args.Result == BoundUserInterfaceRangeResult.Fail)
            return;

        if (!Transform(ent.Owner).Anchored)
        {
            args.Result = BoundUserInterfaceRangeResult.Fail;
        }
    }

    private void OnActivatableUIOpenAttempt(Entity<ActivatableUIRequiresAnchorComponent> ent, ref ActivatableUIOpenAttemptEvent args)
    {
        if (args.Cancelled)
            return;

        if (!Transform(ent.Owner).Anchored)
        {
            _popup.PopupClient(Loc.GetString("comp-gas-pump-ui-needs-anchor"), args.User);
            args.Cancel();
        }
    }
}
