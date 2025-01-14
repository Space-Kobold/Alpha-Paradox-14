// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Prototypes;

namespace Content.Shared.Chemistry.Reaction;

[Prototype("reactiveGroup")]
public sealed partial class ReactiveGroupPrototype : IPrototype
{
    [IdDataField]
    public string ID { get; private set; } = default!;
}
