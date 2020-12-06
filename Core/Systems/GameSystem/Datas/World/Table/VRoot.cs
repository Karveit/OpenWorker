﻿using System.Xml;

namespace Core.Systems.GameSystem.Datas.World.Table
{
    public sealed class VRoot
    {
        public EventBox.VEntities EventBox { get; }
        public EventPoint.VEntities EventPoint { get; }

        internal VRoot(XmlNode xml)
        {
            EventBox = new(xml.SelectSingleNode("Batchs [@eventtype='EventBox']"));
            EventPoint = new(xml.SelectSingleNode("Batchs [@eventtype='EventPoint']"));
        }
    }
}