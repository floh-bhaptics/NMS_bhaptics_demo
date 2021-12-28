﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0xF6D68847AB6B3C0F, NameHash = 0xFAC8C84FEF536E3)]
    public class GcHeavyAirList : NMSTemplate
    {
        public List<NMSString0x80> Options;
    }
}