// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using System.Collections.Immutable;
using Robust.Shared.Prototypes;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom.Prototype.List;

namespace Content.Shared.EntityList
{
    [Prototype("entityList")]
    public sealed partial class EntityListPrototype : IPrototype
    {
        [ViewVariables]
        [IdDataField]
        public string ID { get; private set; } = default!;

        [DataField("entities", customTypeSerializer: typeof(PrototypeIdListSerializer<EntityPrototype>))]
        public ImmutableList<string> EntityIds { get; private set; } = ImmutableList<string>.Empty;

        public IEnumerable<EntityPrototype> Entities(IPrototypeManager? prototypeManager = null)
        {
            prototypeManager ??= IoCManager.Resolve<IPrototypeManager>();

            foreach (var entityId in EntityIds)
            {
                yield return prototypeManager.Index<EntityPrototype>(entityId);
            }
        }
    }
}
