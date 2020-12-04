using Core.Extensions;
using Core.Systems.NetSystem.Attributes;
using System.IO;
using System.Numerics;

namespace Core.Systems.NetSystem.Requests.Movement
{
    [Request]
    public readonly struct StopRequest
    {
        public int CharacterId { get; }
        public ulong Unknown1 { get; }
        public Vector3 Position { get; }
        public float Rotation { get; }
        public float Unknown4 { get; }
        public byte Unknown5 { get; }

        public StopRequest(BinaryReader br)
        {
            CharacterId = br.ReadInt32();
            Unknown1 = br.ReadUInt64();
            Position = br.ReadVector3();
            Rotation = br.ReadSingle();
            Unknown4 = br.ReadSingle();
            Unknown5 = br.ReadByte();
        }
    }
}