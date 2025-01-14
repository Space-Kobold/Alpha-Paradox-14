// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.Explosion.Components
{
    [RegisterComponent]
    public sealed partial class TriggerOnCollideComponent : Component
    {
		[DataField("fixtureID", required: true)]
		public string FixtureID = String.Empty;

        /// <summary>
        ///     Doesn't trigger if the other colliding fixture is nonhard.
        /// </summary>
        [DataField("ignoreOtherNonHard")]
        public bool IgnoreOtherNonHard = true;
    }
}
