// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom;

namespace Content.Server.Spreader;

[RegisterComponent, Access(typeof(KudzuSystem)), AutoGenerateComponentPause]
public sealed partial class GrowingKudzuComponent : Component
{
    /// <summary>
    /// The next time kudzu will try to tick its growth level.
    /// </summary>
    [DataField("nextTick", customTypeSerializer:typeof(TimeOffsetSerializer))]
    [AutoPausedField]
    public TimeSpan NextTick = TimeSpan.Zero;
}
