﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x40, GUID = 0xA6EC1041FE8F1AF9, NameHash = 0xE4AFCD52DEB8A62F)]
    public class GcGalaxyStarColours : NMSTemplate
    {
        [NMS(Size = 0x4, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        public Colour[] ColourByStarType;
    }
}