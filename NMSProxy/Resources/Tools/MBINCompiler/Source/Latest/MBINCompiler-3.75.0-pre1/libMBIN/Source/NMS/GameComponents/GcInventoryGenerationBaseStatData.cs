﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x40, GUID = 0xEE43876427F39D95, NameHash = 0x7A13912B545C6365)]
    public class GcInventoryGenerationBaseStatData : NMSTemplate
    {
        [NMS(Size = 0x4, EnumType = typeof(GcInventoryClass.InventoryClassEnum))]
        public GcInventoryGenerationBaseStatClassData[] BaseStatsPerClass;

    }
}
