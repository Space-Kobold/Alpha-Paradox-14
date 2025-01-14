// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Light.EntitySystems;

namespace Content.Server.Light.Components
{
    // TODO PoweredLight also snowflakes this behavior. Ideally, powered light is renamed to 'wall light' and the
    // actual 'light on power' stuff is just handled by this component.
    /// <summary>
    ///     Enables or disables a pointlight depending on the powered
    ///     state of an entity.
    /// </summary>
    [RegisterComponent, Access(typeof(PoweredLightSystem))]
    public sealed partial class LitOnPoweredComponent : Component
    {
    }
}
