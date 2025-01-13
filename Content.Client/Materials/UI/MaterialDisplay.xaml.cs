// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Client.Stylesheets;
using Content.Shared.Materials;
using Robust.Client.AutoGenerated;
using Robust.Client.GameObjects;
using Robust.Client.UserInterface;
using Robust.Client.UserInterface.Controls;
using Robust.Client.UserInterface.XAML;
using Robust.Shared.Prototypes;

namespace Content.Client.Materials.UI;

/// <summary>
/// This widget is one row in the material storage control.
/// </summary>
[GenerateTypedNameReferences]
public sealed partial class MaterialDisplay : PanelContainer
{
    [Dependency] private readonly IPrototypeManager _prototypeManager = default!;
    [Dependency] private readonly IEntityManager _entityManager = default!;

    private readonly MaterialStorageSystem _materialStorage;

    private readonly MaterialStorageUIController _materialUIController;

    private int _volume;
    private readonly EntityUid _ent;
    public readonly string Material;
    private readonly bool _canEject;

    public MaterialDisplay(EntityUid ent, string material, int volume, bool canEject)
    {
        RobustXamlLoader.Load(this);
        IoCManager.InjectDependencies(this);

        _materialStorage = _entityManager.System<MaterialStorageSystem>();
        _materialUIController = UserInterfaceManager.GetUIController<MaterialStorageUIController>();

        var spriteSys = _entityManager.System<SpriteSystem>();
        Icon.Texture = spriteSys.Frame0(_prototypeManager.Index<MaterialPrototype>(material).Icon);

        _ent = ent;
        Material = material;
        _canEject = canEject;
        UpdateVolume(volume);
    }

    public void UpdateVolume(int volume)
    {
        if (_volume == volume)
            return;

        _volume = volume;
        var matProto = _prototypeManager.Index<MaterialPrototype>(Material);

        var sheetVolume = _materialStorage.GetSheetVolume(matProto);
        var sheets = (float) volume / sheetVolume;
        var maxEjectableSheets = (int) MathF.Floor(sheets);

        var unit = Loc.GetString(matProto.Unit);
        var amountText = Loc.GetString("lathe-menu-material-amount", ("amount", sheets), ("unit", unit));
        var name = Loc.GetString(matProto.Name);
        var mat = Loc.GetString("lathe-menu-material-display", ("material", name), ("amount", amountText));
        ProductName.Text = mat;

        PopulateButtons(maxEjectableSheets);
    }

    public void PopulateButtons(int maxEjectableSheets)
    {
        Content.Children.Clear();
        if (!_canEject)
            return;

        int[] sheetsToEjectArray = { 1, 5, 10 };

        for (var i = 0; i < sheetsToEjectArray.Length; i++)
        {
            var sheetsToEject = sheetsToEjectArray[i];

            var styleClass = StyleBase.ButtonOpenBoth;
            if (i == 0)
                styleClass = StyleBase.ButtonOpenRight;
            else if (i == sheetsToEjectArray.Length - 1)
                styleClass = StyleBase.ButtonOpenLeft;

            var button = new Button
            {
                Name = $"{sheetsToEject}",
                Access = AccessLevel.Public,
                Text = Loc.GetString($"{sheetsToEject}"),
                MinWidth = 45,
                StyleClasses = { styleClass }
            };

            button.OnPressed += _ =>
            {
                _materialUIController.SendLatheEjectMessage(_ent, Material, sheetsToEject);
            };

            button.Disabled = maxEjectableSheets < sheetsToEject;

            if (_prototypeManager.TryIndex<MaterialPrototype>(Material, out var proto))
            {
                button.ToolTip = Loc.GetString("lathe-menu-tooltip-display", ("amount", sheetsToEject), ("material", Loc.GetString(proto.Name)));
            }

            Content.AddChild(button);
        }
    }
}
