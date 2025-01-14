// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Serialization;

namespace Content.Shared.Electrocution;

[Serializable, NetSerializable]
public enum ElectrifiedLayers : byte
{
    Sparks,
    HUD,
}

[Serializable, NetSerializable]
public enum ElectrifiedVisuals : byte
{
    ShowSparks, // only shown when zapping someone, deactivated after a short time
    IsElectrified, // if the entity is electrified or not, used for the AI HUD
}
