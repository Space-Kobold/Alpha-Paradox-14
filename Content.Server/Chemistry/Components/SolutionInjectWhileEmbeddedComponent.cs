// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom;


namespace Content.Server.Chemistry.Components;

/// <summary>
/// Used for embeddable entities that should try to inject a
/// contained solution into a target over time while they are embbeded into.
/// </summary>
[RegisterComponent, AutoGenerateComponentPause]
public sealed partial class SolutionInjectWhileEmbeddedComponent : BaseSolutionInjectOnEventComponent {
        ///<summary>
        ///The time at which the injection will happen.
        ///</summary>
        [DataField(customTypeSerializer: typeof(TimeOffsetSerializer)), AutoPausedField]
        public TimeSpan NextUpdate;
        
        ///<summary>
        ///The delay between each injection in seconds.
        ///</summary>
        [DataField]
        public TimeSpan UpdateInterval = TimeSpan.FromSeconds(3);
}

