// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using System.Linq;
using System.Text;
using Content.Client.Actions;
using Content.Client.Message;
using Content.Shared.FixedPoint;
using Content.Shared.Store;
using Robust.Client.AutoGenerated;
using Robust.Client.GameObjects;
using Robust.Client.Graphics;
using Robust.Client.UserInterface.Controls;
using Robust.Client.UserInterface.CustomControls;
using Robust.Client.UserInterface.XAML;
using Robust.Shared.Prototypes;

namespace Content.Client.Store.Ui;

[GenerateTypedNameReferences]
public sealed partial class StoreMenu : DefaultWindow
{
    [Dependency] private readonly IEntityManager _entityManager = default!;
    [Dependency] private readonly IPrototypeManager _prototypeManager = default!;

    private StoreWithdrawWindow? _withdrawWindow;

    public event EventHandler<string>? SearchTextUpdated;
    public event Action<BaseButton.ButtonEventArgs, ListingDataWithCostModifiers>? OnListingButtonPressed;
    public event Action<BaseButton.ButtonEventArgs, string>? OnCategoryButtonPressed;
    public event Action<BaseButton.ButtonEventArgs, string, int>? OnWithdrawAttempt;
    public event Action<BaseButton.ButtonEventArgs>? OnRefundAttempt;

    public Dictionary<ProtoId<CurrencyPrototype>, FixedPoint2> Balance = new();
    public string CurrentCategory = string.Empty;

    private List<ListingDataWithCostModifiers> _cachedListings = new();

    public StoreMenu()
    {
        RobustXamlLoader.Load(this);
        IoCManager.InjectDependencies(this);

        WithdrawButton.OnButtonDown += OnWithdrawButtonDown;
        RefundButton.OnButtonDown += OnRefundButtonDown;
        SearchBar.OnTextChanged += _ => SearchTextUpdated?.Invoke(this, SearchBar.Text);
    }

    public void UpdateBalance(Dictionary<ProtoId<CurrencyPrototype>, FixedPoint2> balance)
    {
        Balance = balance;

        var currency = balance.ToDictionary(type =>
            (type.Key, type.Value), type => _prototypeManager.Index(type.Key));

        var balanceStr = string.Empty;
        foreach (var ((_, amount), proto) in currency)
        {
            balanceStr += Loc.GetString("store-ui-balance-display", ("amount", amount),
                ("currency", Loc.GetString(proto.DisplayName, ("amount", 1)))) + "\n";
        }

        BalanceInfo.SetMarkup(balanceStr.TrimEnd());

        var disabled = true;
        foreach (var type in currency)
        {
            if (type.Value.CanWithdraw && type.Value.Cash != null && type.Key.Item2 > 0)
            {
                disabled = false;
                break;
            }
        }

        WithdrawButton.Disabled = disabled;
    }

    public void UpdateListing(List<ListingDataWithCostModifiers> listings)
    {
        _cachedListings = listings;

        UpdateListing();
    }

    public void UpdateListing()
    {
        var sorted = _cachedListings.OrderBy(l => l.Priority)
                                    .ThenBy(l => l.Cost.Values.Sum());

        // should probably chunk these out instead. to-do if this clogs the internet tubes.
        // maybe read clients prototypes instead?
        ClearListings();
        foreach (var item in sorted)
        {
            AddListingGui(item);
        }
    }

    public void SetFooterVisibility(bool visible)
    {
        TraitorFooter.Visible = visible;
    }

    private void OnWithdrawButtonDown(BaseButton.ButtonEventArgs args)
    {
        // check if window is already open
        if (_withdrawWindow != null && _withdrawWindow.IsOpen)
        {
            _withdrawWindow.MoveToFront();
            return;
        }

        // open a new one
        _withdrawWindow = new StoreWithdrawWindow();
        _withdrawWindow.OpenCentered();

        _withdrawWindow.CreateCurrencyButtons(Balance);
        _withdrawWindow.OnWithdrawAttempt += OnWithdrawAttempt;
    }

    private void OnRefundButtonDown(BaseButton.ButtonEventArgs args)
    {
        OnRefundAttempt?.Invoke(args);
    }

    private void AddListingGui(ListingDataWithCostModifiers listing)
    {
        if (!listing.Categories.Contains(CurrentCategory))
            return;

        var hasBalance = listing.CanBuyWith(Balance);

        var spriteSys = _entityManager.EntitySysManager.GetEntitySystem<SpriteSystem>();

        Texture? texture = null;
        if (listing.Icon != null)
            texture = spriteSys.Frame0(listing.Icon);

        if (listing.ProductEntity != null)
        {
            if (texture == null)
                texture = spriteSys.GetPrototypeIcon(listing.ProductEntity).Default;
        }
        else if (listing.ProductAction != null)
        {
            var actionId = _entityManager.Spawn(listing.ProductAction);
            if (_entityManager.System<ActionsSystem>().TryGetActionData(actionId, out var action) &&
                action.Icon != null)
            {
                texture = spriteSys.Frame0(action.Icon);
            }
        }

        var listingInStock = GetListingPriceString(listing);
        var discount = GetDiscountString(listing);

        var newListing = new StoreListingControl(listing, listingInStock, discount, hasBalance, texture);
        newListing.StoreItemBuyButton.OnButtonDown += args
            => OnListingButtonPressed?.Invoke(args, listing);

        StoreListingsContainer.AddChild(newListing);
    }

    private string GetListingPriceString(ListingDataWithCostModifiers listing)
    {
        var text = string.Empty;

        if (listing.Cost.Count < 1)
            text = Loc.GetString("store-currency-free");
        else
        {
            foreach (var (type, amount) in listing.Cost)
            {
                var currency = _prototypeManager.Index(type);

                text += Loc.GetString(
                    "store-ui-price-display",
                    ("amount", amount),
                    ("currency", Loc.GetString(currency.DisplayName, ("amount", amount)))
                );
            }
        }

        return text.TrimEnd();
    }

    private string GetDiscountString(ListingDataWithCostModifiers listingDataWithCostModifiers)
    {
        string discountMessage;

        if (!listingDataWithCostModifiers.IsCostModified)
        {
            return string.Empty;
        }

        var relativeModifiersSummary = listingDataWithCostModifiers.GetModifiersSummaryRelative();
        if (relativeModifiersSummary.Count > 1)
        {
            var sb = new StringBuilder();
            sb.Append('(');
            foreach (var (currency, amount) in relativeModifiersSummary)
            {
                var currencyPrototype = _prototypeManager.Index(currency);
                if (sb.Length != 0)
                {
                    sb.Append(", ");
                }
                var currentDiscountMessage = Loc.GetString(
                    "store-ui-discount-display-with-currency",
                    ("amount", amount.ToString("P0")),
                    ("currency", Loc.GetString(currencyPrototype.DisplayName))
                );
                sb.Append(currentDiscountMessage);
            }

            sb.Append(')');
            discountMessage = sb.ToString();
        }
        else
        {
            // if cost was modified - it should have diff relatively to original cost in 1 or more currency
            // ReSharper disable once GenericEnumeratorNotDisposed Dictionary enumerator doesn't require dispose
            var enumerator = relativeModifiersSummary.GetEnumerator();
            enumerator.MoveNext();
            var amount = enumerator.Current.Value;
            discountMessage = Loc.GetString(
                "store-ui-discount-display",
                ("amount", (amount.ToString("P0")))
            );
        }

        return discountMessage;
    }

    private void ClearListings()
    {
        StoreListingsContainer.Children.Clear();
    }

    public void PopulateStoreCategoryButtons(HashSet<ListingDataWithCostModifiers> listings)
    {
        var allCategories = new List<StoreCategoryPrototype>();
        foreach (var listing in listings)
        {
            foreach (var cat in listing.Categories)
            {
                var proto = _prototypeManager.Index(cat);
                if (!allCategories.Contains(proto))
                    allCategories.Add(proto);
            }
        }

        allCategories = allCategories.OrderBy(c => c.Priority).ToList();

        // This will reset the Current Category selection if nothing matches the search.
        if (allCategories.All(category => category.ID != CurrentCategory))
            CurrentCategory = string.Empty;

        if (CurrentCategory == string.Empty && allCategories.Count > 0)
            CurrentCategory = allCategories.First().ID;

        CategoryListContainer.Children.Clear();
        if (allCategories.Count < 1)
            return;

        var group = new ButtonGroup();
        foreach (var proto in allCategories)
        {
            var catButton = new StoreCategoryButton
            {
                Text = Loc.GetString(proto.Name),
                Id = proto.ID,
                Pressed = proto.ID == CurrentCategory,
                Group = group,
                ToggleMode = true,
                StyleClasses = { "OpenBoth" }
            };

            catButton.OnPressed += args => OnCategoryButtonPressed?.Invoke(args, catButton.Id);
            CategoryListContainer.AddChild(catButton);
        }
    }

    public override void Close()
    {
        base.Close();
        _withdrawWindow?.Close();
    }

    public void UpdateRefund(bool allowRefund)
    {
        RefundButton.Visible = allowRefund;
    }

    private sealed class StoreCategoryButton : Button
    {
        public string? Id;
    }
}
