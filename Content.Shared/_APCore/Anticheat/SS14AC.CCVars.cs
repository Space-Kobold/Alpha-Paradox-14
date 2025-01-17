// ***
// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
// If a copy of the MPL was not distributed with this file, You can obtain one at https://mozilla.org/MPL/2.0/.
// This Source Code Form is "Incompatible With Secondary Licenses", as defined by the Mozilla Public License, v. 2.0.
// ***

using Robust.Shared.Configuration;

namespace Content.Shared._APCore.Anticheat;

[CVarDefs]
public sealed class SS14ACCvars
{
    public static readonly CVarDef<bool> Enabled =
        CVarDef.Create("ss14ac.enabled", true, CVar.SERVERONLY);

    /// <summary>
    ///     Permanently ban on check failure.
    /// </summary>
    public static readonly CVarDef<bool> BanOnCheckFailure =
        CVarDef.Create("ss14ac.BanOnFail", false, CVar.SERVERONLY);
}
