﻿using System.Collections.Generic;

namespace ow.Framework.IO.Network.Responses
{
    public sealed record DayEventBoosterResponse
    {
        public sealed record Entity
        {
            public ushort Id { get; init; }
            public ushort Maze { get; init; }
        }

        public IReadOnlyList<Entity> Values { get; init; } = default!;
    }
}