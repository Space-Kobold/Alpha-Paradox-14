// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Serialization;

namespace Content.Shared.Preferences
{
    /// <summary>
    /// Information needed for character setup.
    /// </summary>
    [Serializable, NetSerializable]
    public sealed class GameSettings
    {
        private int _maxCharacterSlots;

        public int MaxCharacterSlots
        {
            get => _maxCharacterSlots;
            set => _maxCharacterSlots = value;
        }
    }
}
