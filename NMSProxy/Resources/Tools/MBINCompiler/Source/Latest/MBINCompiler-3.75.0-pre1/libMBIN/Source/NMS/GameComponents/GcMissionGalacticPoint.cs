﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0x1A248F0F98435D2F, NameHash = 0xA75A686CCD91261E)]
    public class GcMissionGalacticPoint : NMSTemplate
    {
		public enum GalacticPointEnum { Atlas, BlackHole }
		public GalacticPointEnum GalacticPoint;
    }
}