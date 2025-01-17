// ***
// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
// If a copy of the MPL was not distributed with this file, You can obtain one at https://mozilla.org/MPL/2.0/.
// This Source Code Form is "Incompatible With Secondary Licenses", as defined by the Mozilla Public License, v. 2.0.
// ***

using Lidgren.Network;
using Robust.Shared.Network;
using Robust.Shared.Serialization;

namespace Content.Shared._APCore.Anticheat;

public sealed class ACReflectionCheckRepMsg : NetMessage
{
    private int _length;
    public List<string> Modules = [];

    public override MsgGroups MsgGroup => MsgGroups.String;

    public override void ReadFromBuffer(NetIncomingMessage buffer, IRobustSerializer serializer)
    {
        _length = buffer.ReadInt32();

        for (var i = 0; i < _length; i++)
        {
            var mod = buffer.ReadString();
            Modules.Add(mod);
        }
    }

    public override void WriteToBuffer(NetOutgoingMessage buffer, IRobustSerializer serializer)
    {
        buffer.Write(Modules.Count);

        foreach (var module in Modules)
        {
            buffer.Write(module);
        }
    }
}

public sealed class ACReflectionCheckReqMsg : NetMessage
{
    public override MsgGroups MsgGroup => MsgGroups.String;

    public override void ReadFromBuffer(NetIncomingMessage buffer, IRobustSerializer serializer) {}

    public override void WriteToBuffer(NetOutgoingMessage buffer, IRobustSerializer serializer) {}
}
