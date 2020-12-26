﻿using System.IO;
using ow.Framework.IO.Network.Attributes;

namespace ow.Framework.IO.Network.Requests
{
    [Request]
    public readonly struct CharacterSelectRequest
    {
        public int Id { get; }
        private byte[] Unknown { get; }

        public CharacterSelectRequest(BinaryReader br)
        {
            Id = br.ReadInt32();
            Unknown = br.ReadBytes(13);
        }
    }
}
