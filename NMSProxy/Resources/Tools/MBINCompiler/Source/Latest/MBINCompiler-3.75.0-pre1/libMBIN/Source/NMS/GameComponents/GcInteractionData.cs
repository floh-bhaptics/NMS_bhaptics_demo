﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x20, GUID = 0x3CFD2D492048F389, NameHash = 0x84279994558A47D)]
    public class GcInteractionData : NMSTemplate
    {
        public ulong GalacticAddress;
        public ulong Value;
        public Vector4f Position;
    }
}
