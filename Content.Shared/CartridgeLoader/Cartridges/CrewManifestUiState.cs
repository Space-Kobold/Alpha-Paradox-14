// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.CrewManifest;
using Robust.Shared.Serialization;

namespace Content.Shared.CartridgeLoader.Cartridges;

[Serializable, NetSerializable]
public sealed class CrewManifestUiState : BoundUserInterfaceState
{
    public string StationName;
    public CrewManifestEntries? Entries;

    public CrewManifestUiState(string stationName, CrewManifestEntries? entries)
    {
        StationName = stationName;
        Entries = entries;
    }
}
