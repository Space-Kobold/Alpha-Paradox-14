// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Client.Stylesheets;
using Robust.Client.UserInterface.Controls;

namespace Content.Client.Changelog
{
    public sealed class ChangelogButton : Button
    {
        [Dependency] private readonly ChangelogManager _changelogManager = default!;

        public ChangelogButton()
        {
            IoCManager.InjectDependencies(this);

            // So that measuring before opening returns a correct height,
            // and the window has the correct size when opened.
            Text = " ";
        }

        protected override void EnteredTree()
        {
            base.EnteredTree();

            _changelogManager.NewChangelogEntriesChanged += UpdateStuff;
            UpdateStuff();
        }

        protected override void ExitedTree()
        {
            base.ExitedTree();

            _changelogManager.NewChangelogEntriesChanged -= UpdateStuff;
        }

        private void UpdateStuff()
        {
            if (_changelogManager.NewChangelogEntries)
            {
                Text = Loc.GetString("changelog-button-new-entries");
                StyleClasses.Add(StyleBase.ButtonCaution);
            }
            else
            {
                Text = Loc.GetString("changelog-button");
                StyleClasses.Remove(StyleBase.ButtonCaution);
            }
        }
    }
}
