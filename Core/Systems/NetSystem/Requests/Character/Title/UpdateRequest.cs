﻿using Core.Systems.NetSystem.Attributes;
using System.IO;

namespace Core.Systems.NetSystem.Requests.Character.Title
{
    [Request]
    public readonly struct UpdateRequest
    {
        private uint Unknown1 { get; }
        private uint Unknown2 { get; }
        private uint Unknown3 { get; }
        private uint Unknown4 { get; }

        public UpdateRequest(BinaryReader br)
        {
            Unknown1 = br.ReadUInt32();
            Unknown2 = br.ReadUInt32();
            Unknown3 = br.ReadUInt32();
            Unknown4 = br.ReadUInt32();
        }
    }
}
