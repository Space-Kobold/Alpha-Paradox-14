using Content.Client.UserInterface.Controls;
using Content.Shared._APCore.Chemistry.Registry.Systems;
using Content.Shared.Chemistry.Reagent;
using Content.Shared.Kitchen;
using Robust.Client.AutoGenerated;
using Robust.Client.GameObjects;
using Robust.Client.UserInterface.Controls;
using Robust.Client.UserInterface.XAML;
using Robust.Shared.Prototypes;

namespace Content.Client.Kitchen.UI
{
    [GenerateTypedNameReferences]
    public sealed partial class GrinderMenu : FancyWindow
    {
        [Dependency] private readonly IEntityManager _entityManager = default!;
        [Dependency] private readonly IPrototypeManager _prototypeManager = default!;

        private readonly ChemRegistrySystem _chemRegistry;

        private readonly Dictionary<int, EntityUid> _chamberVisualContents = new();

        public event Action? OnToggleAuto;
        public event Action? OnGrind;
        public event Action? OnJuice;
        public event Action? OnEjectAll;
        public event Action? OnEjectBeaker;
        public event Action<EntityUid>? OnEjectChamber;

        public GrinderMenu()
        {
            RobustXamlLoader.Load(this);
            IoCManager.InjectDependencies(this);
            _chemRegistry = _entityManager.System<ChemRegistrySystem>();
            AutoModeButton.OnPressed += _ => OnToggleAuto?.Invoke();
            GrindButton.OnPressed += _ => OnGrind?.Invoke();
            JuiceButton.OnPressed += _ => OnJuice?.Invoke();
            ChamberContentBox.EjectButton.OnPressed += _ => OnEjectAll?.Invoke();
            BeakerContentBox.EjectButton.OnPressed += _ => OnEjectBeaker?.Invoke();
            ChamberContentBox.BoxContents.OnItemSelected += OnChamberBoxContentsItemSelected;
            BeakerContentBox.BoxContents.SelectMode = ItemList.ItemListSelectMode.None;
        }

        private void OnChamberBoxContentsItemSelected(ItemList.ItemListSelectedEventArgs args)
        {
            OnEjectChamber?.Invoke(_chamberVisualContents[args.ItemIndex]);
        }

        public void UpdateState(ReagentGrinderInterfaceState state)
        {
            BeakerContentBox.EjectButton.Disabled = !state.HasBeakerIn;
            ChamberContentBox.EjectButton.Disabled = state.ChamberContents.Length <= 0;
            GrindButton.Disabled = !state.CanGrind || !state.Powered;
            JuiceButton.Disabled = !state.CanJuice || !state.Powered;

            switch (state.AutoMode)
            {
                case GrinderAutoMode.Grind:
                    AutoModeButton.Text = Loc.GetString("grinder-menu-grind-button");
                    break;
                case GrinderAutoMode.Juice:
                    AutoModeButton.Text = Loc.GetString("grinder-menu-juice-button");
                    break;
                default:
                    AutoModeButton.Text = Loc.GetString("grinder-menu-auto-button-off");
                    break;
            }

            // TODO move this to a component state and ensure the net ids.
            RefreshContentsDisplay(state.ReagentQuantities, _entityManager.GetEntityArray(state.ChamberContents), state.HasBeakerIn);
        }

        public void HandleMessage(BoundUserInterfaceMessage message)
        {
            switch (message)
            {
                case ReagentGrinderWorkStartedMessage workStarted:
                    GrindButton.Disabled = true;
                    GrindButton.Modulate = workStarted.GrinderProgram == GrinderProgram.Grind ? Color.Green : Color.White;
                    JuiceButton.Disabled = true;
                    JuiceButton.Modulate = workStarted.GrinderProgram == GrinderProgram.Juice ? Color.Green : Color.White;
                    BeakerContentBox.EjectButton.Disabled = true;
                    ChamberContentBox.EjectButton.Disabled = true;
                    break;
                case ReagentGrinderWorkCompleteMessage:
                    GrindButton.Disabled = false;
                    JuiceButton.Disabled = false;
                    GrindButton.Modulate = Color.White;
                    JuiceButton.Modulate = Color.White;
                    BeakerContentBox.EjectButton.Disabled = false;
                    ChamberContentBox.EjectButton.Disabled = false;
                    break;
            }
        }

        private void RefreshContentsDisplay(IList<ReagentQuantity>? reagents, IReadOnlyList<EntityUid> containedSolids, bool isBeakerAttached)
        {
            //Refresh chamber contents
            _chamberVisualContents.Clear();

            ChamberContentBox.BoxContents.Clear();
            foreach (var entity in containedSolids)
            {
                if (!_entityManager.EntityExists(entity))
                {
                    return;
                }

                var texture = _entityManager.GetComponent<SpriteComponent>(entity).Icon?.Default;

                var solidItem = ChamberContentBox.BoxContents.AddItem(_entityManager.GetComponent<MetaDataComponent>(entity).EntityName, texture);
                var solidIndex = ChamberContentBox.BoxContents.IndexOf(solidItem);
                _chamberVisualContents.Add(solidIndex, entity);
            }

            //Refresh beaker contents
            BeakerContentBox.BoxContents.Clear();
            //if no beaker is attached use this guard to prevent hitting a null reference.
            if (!isBeakerAttached || reagents == null)
            {
                return;
            }

            //Looks like we have a beaker attached.
            if (reagents.Count <= 0)
            {
                BeakerContentBox.BoxContents.AddItem(Loc.GetString("grinder-menu-beaker-content-box-is-empty"));
            }
            else
            {
                foreach (var (reagent, quantity) in reagents)
                {
                    var reagentName = _chemRegistry.TryIndexReagent(reagent.Prototype, out var proto)
                        ? Loc.GetString($"{quantity} {proto.LocalizedName}")
                        : "???";
                    BeakerContentBox.BoxContents.AddItem(reagentName);
                }
            }
        }
    }
}
