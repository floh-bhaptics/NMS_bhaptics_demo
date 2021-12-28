﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0xDDE56711938E1BC7, NameHash = 0x15DCF5F4B3591EDB)]
    public class GcInventoryLayoutGenerationDataEntry : NMSTemplate
    {
        public int MinSlots;            // 1
        public int MaxSlots;            // 5
        public int MinExtraTech;        // 1
        public int MaxExtraTech;        // 3
    }
}