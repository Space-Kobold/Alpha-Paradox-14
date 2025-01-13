// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Mech;
using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface.Controls;
using Robust.Client.UserInterface.XAML;

namespace Content.Client.Mech.Ui.Equipment;

[GenerateTypedNameReferences]
public sealed partial class MechGrabberUiFragment : BoxContainer
{
    [Dependency] private readonly IEntityManager _entity = default!;

    public event Action<EntityUid>? OnEjectAction;

    public MechGrabberUiFragment()
    {
        RobustXamlLoader.Load(this);
        IoCManager.InjectDependencies(this);
    }

    public void UpdateContents(MechGrabberUiState state)
    {
        SpaceLabel.Text = $"{state.Contents.Count}/{state.MaxContents}";
        for (var i = 0; i < state.Contents.Count; i++)
        {
            var ent = _entity.GetEntity(state.Contents[i]);

            if (!_entity.TryGetComponent<MetaDataComponent>(ent, out var meta))
                continue;

            ItemList.AddItem(meta.EntityName);
            ItemList[i].OnSelected += _ => OnEjectAction?.Invoke(ent);
        }
    }
}
