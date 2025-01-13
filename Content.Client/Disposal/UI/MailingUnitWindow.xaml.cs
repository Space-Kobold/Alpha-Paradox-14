// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Disposal;
using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface.CustomControls;
using Robust.Client.UserInterface.XAML;
using Robust.Shared.Timing;

namespace Content.Client.Disposal.UI
{
    /// <summary>
    /// Client-side UI used to control a <see cref="MailingUnitComponent"/>
    /// </summary>
    [GenerateTypedNameReferences]
    public sealed partial class MailingUnitWindow : DefaultWindow
    {
        public TimeSpan FullPressure;

        public MailingUnitWindow()
        {
            RobustXamlLoader.Load(this);
        }

        /// <summary>
        /// Update the interface state for the disposals window.
        /// </summary>
        /// <returns>true if we should stop updating every frame.</returns>
        public bool UpdateState(MailingUnitBoundUserInterfaceState state)
        {
            var disposalState = state.DisposalState;

            Title = Loc.GetString("ui-mailing-unit-window-title", ("tag", state.Tag ?? " "));
            UnitState.Text = disposalState.UnitState;
            FullPressure = disposalState.FullPressureTime;
            var pressureReached = PressureBar.UpdatePressure(disposalState.FullPressureTime);
            Power.Pressed = disposalState.Powered;
            Engage.Pressed = disposalState.Engaged;

            //UnitTag.Text = state.Tag;
            Target.Text = state.Target;

            TargetListContainer.Clear();
            foreach (var target in state.TargetList)
            {
                TargetListContainer.AddItem(target);
            }

            return !disposalState.Powered || pressureReached;
        }

        protected override void FrameUpdate(FrameEventArgs args)
        {
            base.FrameUpdate(args);
            PressureBar.UpdatePressure(FullPressure);
        }
    }
}
