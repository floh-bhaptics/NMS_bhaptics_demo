﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xA0, GUID = 0xC94CB973E523C055, NameHash = 0x6E90E2A796E798F4)]
    public class GcHeavyAirSetting : NMSTemplate
    {
        [NMS(Size = 5)]
        public GcHeavyAirSettingValues[] Settings;
    }
}
