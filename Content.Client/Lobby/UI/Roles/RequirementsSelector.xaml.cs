// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using System.Numerics;
using Content.Client.Stylesheets;
using Content.Client.UserInterface.Controls;
using Content.Shared.Guidebook;
using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface.Controls;
using Robust.Client.UserInterface.CustomControls;
using Robust.Client.UserInterface.XAML;
using Robust.Shared.Prototypes;
using Robust.Shared.Utility;

namespace Content.Client.Lobby.UI.Roles;

/// <summary>
/// A generic locking selector.
/// </summary>
[GenerateTypedNameReferences]
public sealed partial class RequirementsSelector : BoxContainer
{
    private readonly RadioOptions<int> _options;
    private readonly StripeBack _lockStripe;
    private List<ProtoId<GuideEntryPrototype>>? _guides;

    public event Action<int>? OnSelected;
    public event Action<List<ProtoId<GuideEntryPrototype>>>? OnOpenGuidebook;

    public int Selected => _options.SelectedId;

    public RequirementsSelector()
    {
        RobustXamlLoader.Load(this);
        _options = new RadioOptions<int>(RadioOptionsLayout.Horizontal)
        {
            FirstButtonStyle = StyleBase.ButtonOpenRight,
            ButtonStyle = StyleBase.ButtonOpenBoth,
            LastButtonStyle = StyleBase.ButtonOpenLeft,
            HorizontalExpand = true,
        };
        //Override default radio option button width
        _options.GenerateItem = GenerateButton;

        _options.OnItemSelected += args =>
        {
            _options.Select(args.Id);
            OnSelected?.Invoke(args.Id);
        };

        var requirementsLabel = new Label()
        {
            Text = Loc.GetString("role-timer-locked"),
            Visible = true,
            HorizontalAlignment = HAlignment.Center,
            StyleClasses = {StyleBase.StyleClassLabelSubText},
        };

        _lockStripe = new StripeBack()
        {
            Visible = false,
            HorizontalExpand = true,
            HasMargins = false,
            MouseFilter = MouseFilterMode.Stop,
            Children =
            {
                requirementsLabel
            }
        };

        Help.OnPressed += _ =>
        {
            if (_guides != null)
                OnOpenGuidebook?.Invoke(_guides);
        };
    }

    /// <summary>
    /// Actually adds the controls.
    /// </summary>
    public void Setup(
        (string, int)[] items,
        string title,
        int titleSize,
        string? description,
        TextureRect? icon = null,
        List<ProtoId<GuideEntryPrototype>>? guides = null)
    {
        foreach (var (text, value) in items)
        {
            _options.AddItem(Loc.GetString(text), value);
        }

        Help.Visible = guides != null;
        _guides = guides;

        TitleLabel.Text = title;
        TitleLabel.MinSize = new Vector2(titleSize, 0f);
        TitleLabel.ToolTip = description;

        if (icon != null)
        {
            AddChild(icon);
            icon.SetPositionFirst();
        }

        OptionsContainer.AddChild(_options);
        OptionsContainer.AddChild(_lockStripe);
    }

    public void LockRequirements(FormattedMessage requirements)
    {
        var tooltip = new Tooltip();
        tooltip.SetMessage(requirements);
        _lockStripe.TooltipSupplier = _ => tooltip;
        _lockStripe.Visible = true;
        _options.Visible = false;
    }

    public void UnlockRequirements()
    {
        _lockStripe.Visible = false;
        _options.Visible = true;
    }

    private Button GenerateButton(string text, int value)
    {
        return new Button
        {
            Text = text,
            MinWidth = 90,
            HorizontalExpand = true,
        };
    }

    public void Select(int id)
    {
        _options.Select(id);
    }
}
