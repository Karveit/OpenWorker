﻿using System;

namespace TrinigyVisionEngine.Vision.Runtime.EnginePlugins.Game.World.Batch
{
    [Flags]
    public enum CreationConditionType
    {
        Disable,
        Immediate,
        WaitSignal
    }
}