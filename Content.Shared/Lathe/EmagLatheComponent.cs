// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Research.Prototypes;
using Robust.Shared.GameStates;
using Robust.Shared.Prototypes;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom.Prototype.List;

namespace Content.Shared.Lathe
{
    [RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
    public sealed partial class EmagLatheRecipesComponent : Component
    {
        /// <summary>
        /// All of the dynamic recipes that the lathe is capable to get using EMAG
        /// </summary>
        [DataField, AutoNetworkedField]
        public List<ProtoId<LatheRecipePrototype>> EmagDynamicRecipes = new();

        /// <summary>
        /// All of the static recipes that the lathe is capable to get using EMAG
        /// </summary>
        [DataField, AutoNetworkedField]
        public List<ProtoId<LatheRecipePrototype>> EmagStaticRecipes = new();
    }
}
