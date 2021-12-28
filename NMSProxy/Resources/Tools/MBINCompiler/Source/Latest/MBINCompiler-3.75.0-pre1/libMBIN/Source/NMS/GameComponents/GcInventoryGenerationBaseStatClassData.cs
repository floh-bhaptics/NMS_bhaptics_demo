﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0x3F821EFA320B5781, NameHash = 0xADE121F93A7D37D0)]
    public class GcInventoryGenerationBaseStatClassData : NMSTemplate
    {
        public List<GcInventoryGenerationBaseStatDataEntry> BaseStats;
    }
}