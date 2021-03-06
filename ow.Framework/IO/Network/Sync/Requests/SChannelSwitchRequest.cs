using ow.Framework.IO.Network.Sync.Attributes;
using System.IO;

namespace ow.Framework.IO.Network.Sync.Requests
{
    [Request]
    public readonly struct SChannelSwitchRequest
    {
        public ushort Id { get; }

        public SChannelSwitchRequest(BinaryReader br) =>
            Id = br.ReadUInt16();
    }
}