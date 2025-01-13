// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Traits;
using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface;
using Robust.Client.UserInterface.Controls;
using Robust.Client.UserInterface.XAML;

namespace Content.Client.Lobby.UI.Roles;

[GenerateTypedNameReferences]
public sealed partial class TraitPreferenceSelector : Control
{
    public int Cost;

    public bool Preference
    {
        get => Checkbox.Pressed;
        set => Checkbox.Pressed = value;
    }

    public event Action<bool>? PreferenceChanged;

    public TraitPreferenceSelector(TraitPrototype trait)
    {
        RobustXamlLoader.Load(this);

        var text = trait.Cost != 0 ? $"[{trait.Cost}] " : "";
        text += Loc.GetString(trait.Name);

        Cost = trait.Cost;
        Checkbox.Text = text;
        Checkbox.OnToggled += OnCheckBoxToggled;

        if (trait.Description is { } desc)
        {
            Checkbox.ToolTip = Loc.GetString(desc);
        }
    }

    private void OnCheckBoxToggled(BaseButton.ButtonToggledEventArgs args)
    {
        PreferenceChanged?.Invoke(Preference);
    }
}
