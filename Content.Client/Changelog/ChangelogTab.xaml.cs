// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using System.Linq;
using System.Numerics;
using Content.Client.Resources;
using Content.Client.Stylesheets;
using Robust.Client.AutoGenerated;
using Robust.Client.ResourceManagement;
using Robust.Client.UserInterface;
using Robust.Client.UserInterface.Controls;
using Robust.Client.UserInterface.XAML;
using Robust.Shared.ContentPack;
using Robust.Shared.Utility;
using static Content.Client.Changelog.ChangelogManager;
using static Robust.Client.UserInterface.Controls.BoxContainer;

namespace Content.Client.Changelog;

[GenerateTypedNameReferences]
public sealed partial class ChangelogTab : Control
{
    [Dependency] private readonly ChangelogManager _changelog = default!;
    [Dependency] private readonly IResourceCache _resourceCache = default!;

    public bool AdminOnly;

    public ChangelogTab()
    {
        RobustXamlLoader.Load(this);
        IoCManager.InjectDependencies(this);
    }

    public void PopulateChangelog(ChangelogManager.Changelog changelog)
    {
        var byDay = changelog.Entries
            .GroupBy(e => e.Time.ToLocalTime().Date)
            .OrderByDescending(c => c.Key);

        var hasRead = changelog.Name != MainChangelogName ||
                      _changelog.MaxId <= _changelog.LastReadId;

        foreach (var dayEntries in byDay)
        {
            var day = dayEntries.Key;

            var groupedEntries = dayEntries
                .GroupBy(c => (c.Author, Read: c.Id <= _changelog.LastReadId))
                .OrderBy(c => c.Key.Read)
                .ThenBy(c => c.Key.Author);

            string dayNice;
            var today = DateTime.Today;
            if (day == today)
                dayNice = Loc.GetString("changelog-today");
            else if (day == today.AddDays(-1))
                dayNice = Loc.GetString("changelog-yesterday");
            else
                dayNice = day.ToShortDateString();

            ChangelogBody.AddChild(new Label
            {
                Text = dayNice,
                StyleClasses = { StyleBase.StyleClassLabelHeading },
                Margin = new Thickness(4, 6, 0, 0)
            });

            var first = true;

            foreach (var groupedEntry in groupedEntries)
            {
                var (author, read) = groupedEntry.Key;

                if (!first)
                {
                    ChangelogBody.AddChild(new Control { Margin = new Thickness(4) });
                }

                if (read && !hasRead)
                {
                    hasRead = true;

                    var upArrow =
                        _resourceCache.GetTexture("/Textures/Interface/Changelog/up_arrow.svg.192dpi.png");

                    var readDivider = new BoxContainer
                    {
                        Orientation = LayoutOrientation.Vertical
                    };

                    var hBox = new BoxContainer
                    {
                        Orientation = LayoutOrientation.Horizontal,
                        HorizontalAlignment = HAlignment.Center,
                        Children =
                        {
                            new TextureRect
                            {
                                Texture = upArrow,
                                ModulateSelfOverride = Color.FromHex("#888"),
                                TextureScale = new Vector2(0.5f, 0.5f),
                                Margin = new Thickness(4, 3),
                                VerticalAlignment = VAlignment.Bottom
                            },
                            new Label
                            {
                                Align = Label.AlignMode.Center,
                                Text = Loc.GetString("changelog-new-changes"),
                                FontColorOverride = Color.FromHex("#888"),
                            },
                            new TextureRect
                            {
                                Texture = upArrow,
                                ModulateSelfOverride = Color.FromHex("#888"),
                                TextureScale = new Vector2(0.5f, 0.5f),
                                Margin = new Thickness(4, 3),
                                VerticalAlignment = VAlignment.Bottom
                            }
                        }
                    };

                    readDivider.AddChild(hBox);
                    readDivider.AddChild(new PanelContainer { StyleClasses = { StyleBase.ClassLowDivider } });
                    ChangelogBody.AddChild(readDivider);

                    if (first)
                        readDivider.SetPositionInParent(ChangelogBody.ChildCount - 2);
                }

                first = false;

                var authorLabel = new RichTextLabel
                {
                    Margin = new Thickness(6, 0, 0, 0),
                };
                authorLabel.SetMessage(
                    FormattedMessage.FromMarkupOrThrow(Loc.GetString("changelog-author-changed", ("author", author))));
                ChangelogBody.AddChild(authorLabel);

                foreach (var change in groupedEntry.SelectMany(c => c.Changes))
                {
                    var text = new RichTextLabel();
                    text.SetMessage(FormattedMessage.FromMarkupOrThrow(change.Message));
                    ChangelogBody.AddChild(new BoxContainer
                    {
                        Orientation = LayoutOrientation.Horizontal,
                        Margin = new Thickness(14, 1, 10, 2),
                        Children =
                        {
                            GetIcon(change.Type),
                            text
                        }
                    });
                }
            }
        }
    }

    private TextureRect GetIcon(ChangelogLineType type)
    {
        var (file, color) = type switch
        {
            ChangelogLineType.Add => ("plus.svg.192dpi.png", "#6ED18D"),
            ChangelogLineType.Remove => ("minus.svg.192dpi.png", "#D16E6E"),
            ChangelogLineType.Fix => ("bug.svg.192dpi.png", "#D1BA6E"),
            ChangelogLineType.Tweak => ("wrench.svg.192dpi.png", "#6E96D1"),
            _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
        };

        return new TextureRect
        {
            Texture = _resourceCache.GetTexture(new ResPath($"/Textures/Interface/Changelog/{file}")),
            VerticalAlignment = VAlignment.Top,
            TextureScale = new Vector2(0.5f, 0.5f),
            Margin = new Thickness(2, 4, 6, 2),
            ModulateSelfOverride = Color.FromHex(color)
        };
    }
}
