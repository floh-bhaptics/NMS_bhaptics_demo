﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0xF28FCA1E3D439CD9, NameHash = 0x3F92E065272FE2A9)]
    public class GcCreatureGroupDescription : NMSTemplate
    {
        public NMSString0x10 Group;
        public int MinGroupSize;                // 1
        public int MaxGroupSize;                // 3
        public float GroupsPerSquareKm;         // 41200000h
    }
}