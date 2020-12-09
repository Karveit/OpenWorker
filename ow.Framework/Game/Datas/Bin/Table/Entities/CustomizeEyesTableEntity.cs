﻿using ow.Framework.Game.Ids;
using ow.Framework.Extensions;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ow.Framework.Game.Datas.Bin.Table.Entities
{
    using KeyType = HeroId;

    public sealed class CustomizeEyesTableEntity : ITableEntity<KeyType>
    {
        public KeyType Id { get; }
        public IReadOnlyList<uint> Unknown1 { get; }
        public IReadOnlyList<string> Icons { get; }
        public IReadOnlyList<uint> Color { get; }

        internal CustomizeEyesTableEntity(BinaryReader br)
        {
            Id = br.ReadHeroId();
            Unknown1 = Enumerable.Repeat(0, ItemsCount).Select((e) => br.ReadUInt32()).ToArray();
            Icons = Enumerable.Repeat(0, ItemsCount).Select((e) => br.ReadByteLengthUnicodeString()).ToArray();
            Color = Enumerable.Repeat(0, ItemsCount).Select((e) => br.ReadUInt32()).ToArray();
        }

        private const byte ItemsCount = 10;
    }
}