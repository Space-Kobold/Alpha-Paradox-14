// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.CCVar;

namespace Content.Server.Instruments;

public sealed partial class InstrumentSystem
{
    public int MaxMidiEventsPerSecond { get; private set; }
    public int MaxMidiEventsPerBatch { get; private set; }
    public int MaxMidiBatchesDropped { get; private set; }
    public int MaxMidiLaggedBatches { get; private set; }

    private void InitializeCVars()
    {
        Subs.CVar(_cfg, CCVars.MaxMidiEventsPerSecond, obj => MaxMidiEventsPerSecond = obj, true);
        Subs.CVar(_cfg, CCVars.MaxMidiEventsPerBatch, obj => MaxMidiEventsPerBatch = obj, true);
        Subs.CVar(_cfg, CCVars.MaxMidiBatchesDropped, obj => MaxMidiBatchesDropped = obj, true);
        Subs.CVar(_cfg, CCVars.MaxMidiLaggedBatches, obj => MaxMidiLaggedBatches = obj, true);
    }
}
