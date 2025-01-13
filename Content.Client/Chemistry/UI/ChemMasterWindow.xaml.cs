// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Client.Stylesheets;
using Content.Client.UserInterface.Controls;
using Content.Shared.Chemistry;
using Content.Shared.Chemistry.Reagent;
using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface;
using Robust.Client.UserInterface.Controls;
using Robust.Client.UserInterface.XAML;
using Robust.Client.Utility;
using Robust.Shared.Prototypes;
using Robust.Shared.Utility;
using System.Linq;
using System.Numerics;
using Content.Shared.FixedPoint;
using Robust.Client.Graphics;
using static Robust.Client.UserInterface.Controls.BoxContainer;

namespace Content.Client.Chemistry.UI
{
    /// <summary>
    /// Client-side UI used to control a <see cref="SharedChemMasterComponent"/>
    /// </summary>
    [GenerateTypedNameReferences]
    public sealed partial class ChemMasterWindow : FancyWindow
    {
        [Dependency] private readonly IPrototypeManager _prototypeManager = default!;
        public event Action<BaseButton.ButtonEventArgs, ReagentButton>? OnReagentButtonPressed;
        public readonly Button[] PillTypeButtons;

        private const string PillsRsiPath = "/Textures/Objects/Specific/Chemistry/pills.rsi";

        /// <summary>
        /// Create and initialize the chem master UI client-side. Creates the basic layout,
        /// actual data isn't filled in until the server sends data about the chem master.
        /// </summary>
        public ChemMasterWindow()
        {
            RobustXamlLoader.Load(this);
            IoCManager.InjectDependencies(this);

            // Pill type selection buttons, in total there are 20 pills.
            // Pill rsi file should have states named as pill1, pill2, and so on.
            var resourcePath = new ResPath(PillsRsiPath);
            var pillTypeGroup = new ButtonGroup();
            PillTypeButtons = new Button[20];
            for (uint i = 0; i < PillTypeButtons.Length; i++)
            {
                // For every button decide which stylebase to have
                // Every row has 10 buttons
                String styleBase = StyleBase.ButtonOpenBoth;
                uint modulo = i % 10;
                if (i > 0 && modulo == 0)
                    styleBase = StyleBase.ButtonOpenRight;
                else if (i > 0 && modulo == 9)
                    styleBase = StyleBase.ButtonOpenLeft;
                else if (i == 0)
                    styleBase = StyleBase.ButtonOpenRight;

                // Generate buttons
                PillTypeButtons[i] = new Button
                {
                    Access = AccessLevel.Public,
                    StyleClasses = { styleBase },
                    MaxSize = new Vector2(42, 28),
                    Group = pillTypeGroup
                };

                // Generate buttons textures
                var specifier = new SpriteSpecifier.Rsi(resourcePath, "pill" + (i + 1));
                TextureRect pillTypeTexture = new TextureRect
                {
                    Texture = specifier.Frame0(),
                    TextureScale = new Vector2(1.75f, 1.75f),
                    Stretch = TextureRect.StretchMode.KeepCentered,
                };

                PillTypeButtons[i].AddChild(pillTypeTexture);
                Grid.AddChild(PillTypeButtons[i]);
            }

            PillDosage.InitDefaultButtons();
            PillNumber.InitDefaultButtons();
            BottleDosage.InitDefaultButtons();

            // Ensure label length is within the character limit.
            LabelLineEdit.IsValid = s => s.Length <= SharedChemMaster.LabelMaxLength;

            Tabs.SetTabTitle(0, Loc.GetString("chem-master-window-input-tab"));
            Tabs.SetTabTitle(1, Loc.GetString("chem-master-window-output-tab"));
        }

        private ReagentButton MakeReagentButton(string text, ChemMasterReagentAmount amount, ReagentId id, bool isBuffer, string styleClass)
        {
            var reagentTransferButton = new ReagentButton(text, amount, id, isBuffer, styleClass);
            reagentTransferButton.OnPressed += args
                => OnReagentButtonPressed?.Invoke(args, reagentTransferButton);
            return reagentTransferButton;
        }
        /// <summary>
        /// Conditionally generates a set of reagent buttons based on the supplied boolean argument.
        /// This was moved outside of BuildReagentRow to facilitate conditional logic, stops indentation depth getting out of hand as well.
        /// </summary>
        private List<ReagentButton> CreateReagentTransferButtons(ReagentId reagent, bool isBuffer, bool addReagentButtons)
        {
            if (!addReagentButtons)
                return new List<ReagentButton>(); // Return an empty list if reagentTransferButton creation is disabled.

            var buttonConfigs = new (string text, ChemMasterReagentAmount amount, string styleClass)[]
            {
                ("1", ChemMasterReagentAmount.U1, StyleBase.ButtonOpenBoth),
                ("5", ChemMasterReagentAmount.U5, StyleBase.ButtonOpenBoth),
                ("10", ChemMasterReagentAmount.U10, StyleBase.ButtonOpenBoth),
                ("25", ChemMasterReagentAmount.U25, StyleBase.ButtonOpenBoth),
                ("50", ChemMasterReagentAmount.U50, StyleBase.ButtonOpenBoth),
                ("100", ChemMasterReagentAmount.U100, StyleBase.ButtonOpenBoth),
                (Loc.GetString("chem-master-window-buffer-all-amount"), ChemMasterReagentAmount.All, StyleBase.ButtonOpenLeft),
            };

            var buttons = new List<ReagentButton>();

            foreach (var (text, amount, styleClass) in buttonConfigs)
            {
                var reagentTransferButton = MakeReagentButton(text, amount, reagent, isBuffer, styleClass);
                buttons.Add(reagentTransferButton);
            }

            return buttons;
        }

        /// <summary>
        /// Update the UI state when new state data is received from the server.
        /// </summary>
        /// <param name="state">State data sent by the server.</param>
        public void UpdateState(BoundUserInterfaceState state)
        {
            var castState = (ChemMasterBoundUserInterfaceState)state;

            if (castState.UpdateLabel)
                LabelLine = GenerateLabel(castState);

            // Ensure the Panel Info is updated, including UI elements for Buffer Volume, Output Container and so on
            UpdatePanelInfo(castState);
    
            BufferCurrentVolume.Text = $" {castState.BufferCurrentVolume?.Int() ?? 0}u";
    
            InputEjectButton.Disabled = castState.InputContainerInfo is null;
            OutputEjectButton.Disabled = castState.OutputContainerInfo is null;
            CreateBottleButton.Disabled = castState.OutputContainerInfo?.Reagents == null;
            CreatePillButton.Disabled = castState.OutputContainerInfo?.Entities == null;
            
            UpdateDosageFields(castState);
        }
        
        //assign default values for pill and bottle fields.
        private void UpdateDosageFields(ChemMasterBoundUserInterfaceState castState)
        {
            var output = castState.OutputContainerInfo;
            var remainingCapacity = output is null ? 0 : (output.MaxVolume - output.CurrentVolume).Int();
            var holdsReagents = output?.Reagents != null;
            var pillNumberMax = holdsReagents ? 0 : remainingCapacity;
            var bottleAmountMax = holdsReagents ? remainingCapacity : 0;
            var bufferVolume = castState.BufferCurrentVolume?.Int() ?? 0;

            PillDosage.Value = (int)Math.Min(bufferVolume, castState.PillDosageLimit);
            
            PillTypeButtons[castState.SelectedPillType].Pressed = true;
            PillNumber.IsValid = x => x >= 0 && x <= pillNumberMax;
            PillDosage.IsValid = x => x > 0 && x <= castState.PillDosageLimit;
            BottleDosage.IsValid = x => x >= 0 && x <= bottleAmountMax;

            if (PillNumber.Value > pillNumberMax)
                PillNumber.Value = pillNumberMax;
            if (BottleDosage.Value > bottleAmountMax)
                BottleDosage.Value = bottleAmountMax;

            // Avoid division by zero
            if (PillDosage.Value > 0)
            {
                PillNumber.Value = Math.Min(bufferVolume / PillDosage.Value, pillNumberMax);
            }
            else
            {
                PillNumber.Value = 0;
            }

            BottleDosage.Value = Math.Min(bottleAmountMax, bufferVolume);
        }
        /// <summary>
        /// Generate a product label based on reagents in the buffer.
        /// </summary>
        /// <param name="state">State data sent by the server.</param>
        private string GenerateLabel(ChemMasterBoundUserInterfaceState state)
        {
            if (state.BufferCurrentVolume == 0)
                return "";

            var reagent = state.BufferReagents.OrderBy(r => r.Quantity).First().Reagent;
            _prototypeManager.TryIndex(reagent.Prototype, out ReagentPrototype? proto);
            return proto?.LocalizedName ?? "";
        }

        /// <summary>
        /// Update the container, buffer, and packaging panels.
        /// </summary>
        /// <param name="state">State data for the dispenser.</param>
        private void UpdatePanelInfo(ChemMasterBoundUserInterfaceState state)
        {
            BufferTransferButton.Pressed = state.Mode == ChemMasterMode.Transfer;
            BufferDiscardButton.Pressed = state.Mode == ChemMasterMode.Discard;

            BuildContainerUI(InputContainerInfo, state.InputContainerInfo, true);
            BuildContainerUI(OutputContainerInfo, state.OutputContainerInfo, false);

            BufferInfo.Children.Clear();

            if (!state.BufferReagents.Any())
            {
                BufferInfo.Children.Add(new Label { Text = Loc.GetString("chem-master-window-buffer-empty-text") });

                return;
            }

            var bufferHBox = new BoxContainer
            {
                Orientation = LayoutOrientation.Horizontal
            };
            BufferInfo.AddChild(bufferHBox);

            var bufferLabel = new Label { Text = $"{Loc.GetString("chem-master-window-buffer-label")} " };
            bufferHBox.AddChild(bufferLabel);
            var bufferVol = new Label
            {
                Text = $"{state.BufferCurrentVolume}u",
                StyleClasses = { StyleNano.StyleClassLabelSecondaryColor }
            };
            bufferHBox.AddChild(bufferVol);

            // initialises rowCount to allow for striped rows

            var rowCount = 0;
            foreach (var (reagent, quantity) in state.BufferReagents)
            {
                var reagentId = reagent;
                _prototypeManager.TryIndex(reagentId.Prototype, out ReagentPrototype? proto);
                var name = proto?.LocalizedName ?? Loc.GetString("chem-master-window-unknown-reagent-text");
                var reagentColor = proto?.SubstanceColor ?? default(Color);
                BufferInfo.Children.Add(BuildReagentRow(reagentColor, rowCount++, name, reagentId, quantity, true, true));
            }
        }
        
        private void BuildContainerUI(Control control, ContainerInfo? info, bool addReagentButtons)
        {
            control.Children.Clear();

            if (info is null)
            {
                control.Children.Add(new Label
                {
                    Text = Loc.GetString("chem-master-window-no-container-loaded-text")
                });
                return;
            }

            // Name of the container and its fill status (Ex: 44/100u)
            control.Children.Add(new BoxContainer
            {
                Orientation = LayoutOrientation.Horizontal,
                Children =
                {
                    new Label { Text = $"{info.DisplayName}: " },
                    new Label
                    {
                        Text = $"{info.CurrentVolume}/{info.MaxVolume}",
                        StyleClasses = { StyleNano.StyleClassLabelSecondaryColor }
                    }
                }
            });
            // Initialises rowCount to allow for striped rows
            var rowCount = 0;

            // Handle entities if they are not null
            if (info.Entities != null)
            {
                foreach (var (id, quantity) in info.Entities.Select(x => (x.Id, x.Quantity)))
                {
                    control.Children.Add(BuildReagentRow(default(Color), rowCount++, id, default(ReagentId), quantity, false, addReagentButtons));
                }
            }

            // Handle reagents if they are not null
            if (info.Reagents != null)
            {
                foreach (var reagent in info.Reagents)
                {
                    _prototypeManager.TryIndex(reagent.Reagent.Prototype, out ReagentPrototype? proto);
                    var name = proto?.LocalizedName ?? Loc.GetString("chem-master-window-unknown-reagent-text");
                    var reagentColor = proto?.SubstanceColor ?? default(Color);
        
                    control.Children.Add(BuildReagentRow(reagentColor, rowCount++, name, reagent.Reagent, reagent.Quantity, false, addReagentButtons));
                }
            }
        }
        /// <summary>
        /// Take reagent/entity data and present rows, labels, and buttons appropriately. todo sprites?
        /// </summary>
        private Control BuildReagentRow(Color reagentColor, int rowCount, string name, ReagentId reagent, FixedPoint2 quantity, bool isBuffer, bool addReagentButtons)
        {
            //Colors rows and sets fallback for reagentcolor to the same as background, this will hide colorPanel for entities hopefully
            var rowColor1 = Color.FromHex("#1B1B1E");
            var rowColor2 = Color.FromHex("#202025");
            var currentRowColor = (rowCount % 2 == 1) ? rowColor1 : rowColor2;
            if ((reagentColor == default(Color))|(!addReagentButtons))
            {
                reagentColor = currentRowColor;
            }
            //this calls the separated button builder, and stores the return to render after labels
            var reagentButtonConstructors = CreateReagentTransferButtons(reagent, isBuffer, addReagentButtons);
            
            // Create the row layout with the color panel
            var rowContainer = new BoxContainer
            {
                Orientation = LayoutOrientation.Horizontal,
                Children =
                {
                    new Label { Text = $"{name}: " },
                    new Label
                    {
                        Text = $"{quantity}u",
                        StyleClasses = { StyleNano.StyleClassLabelSecondaryColor }
                    },

                    // Padding
                    new Control { HorizontalExpand = true },
                    // Colored panels for reagents
                    new PanelContainer
                    {
                        Name = "colorPanel",
                        VerticalExpand = true,
                        MinWidth = 4,
                        PanelOverride = new StyleBoxFlat
                        {
                            BackgroundColor = reagentColor
                        },
                        Margin = new Thickness(0, 1)
                    }
                }
            };

            // Add the reagent buttons after the color panel
            foreach (var reagentTransferButton in reagentButtonConstructors)
            {
                rowContainer.AddChild(reagentTransferButton);
            }
            //Apply panencontainer to allow for striped rows
            return new PanelContainer
            {
                PanelOverride = new StyleBoxFlat(currentRowColor),
                Children = { rowContainer }
            };
        }
        
        public string LabelLine
        {
            get => LabelLineEdit.Text;
            set => LabelLineEdit.Text = value;
        }
    }

    public sealed class ReagentButton : Button
    {
        public ChemMasterReagentAmount Amount { get; set; }
        public bool IsBuffer = true;
        public ReagentId Id { get; set; }
        public ReagentButton(string text, ChemMasterReagentAmount amount, ReagentId id, bool isBuffer, string styleClass)
        {
            AddStyleClass(styleClass);
            Text = text;
            Amount = amount;
            Id = id;
            IsBuffer = isBuffer;
        }
    }
}
