// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Client.Guidebook.Controls;
public interface ISearchableControl
{
    public bool CheckMatchesSearch(string query);
    /// <summary>
    ///    Sets the hidden state for the control. In simple cases this could just disable/hide it, but you may want more complex behavior for some elements.
    /// </summary>
    public void SetHiddenState(bool state, string query);
}
