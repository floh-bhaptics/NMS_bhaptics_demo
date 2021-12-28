﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0x47AABCD48527D767, NameHash = 0xA9800C505F52A54E)]
    public class GcInventorySpecialSlotType : NMSTemplate
    {
		public enum InventorySpecialSlotTypeEnum { Broken, TechOnly, Cargo, BlockedByBrokenTech }
		public InventorySpecialSlotTypeEnum InventorySpecialSlotType;
    }
}