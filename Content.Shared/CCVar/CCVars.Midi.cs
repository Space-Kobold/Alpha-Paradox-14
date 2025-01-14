// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Configuration;

namespace Content.Shared.CCVar;

public sealed partial class CCVars
{
    public static readonly CVarDef<int> MaxMidiEventsPerSecond =
        CVarDef.Create("midi.max_events_per_second", 1000, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<int> MaxMidiEventsPerBatch =
        CVarDef.Create("midi.max_events_per_batch", 60, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<int> MaxMidiBatchesDropped =
        CVarDef.Create("midi.max_batches_dropped", 1, CVar.SERVERONLY);

    public static readonly CVarDef<int> MaxMidiLaggedBatches =
        CVarDef.Create("midi.max_lagged_batches", 8, CVar.SERVERONLY);
}
