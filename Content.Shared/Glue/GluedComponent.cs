// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom;

namespace Content.Shared.Glue;

[RegisterComponent]
[Access(typeof(SharedGlueSystem))]
public sealed partial class GluedComponent : Component
{

    [DataField("until", customTypeSerializer: typeof(TimeOffsetSerializer)), ViewVariables(VVAccess.ReadWrite)]
    public TimeSpan Until;

    [DataField("duration", customTypeSerializer: typeof(TimeOffsetSerializer)), ViewVariables(VVAccess.ReadWrite)]
    public TimeSpan Duration;
}
