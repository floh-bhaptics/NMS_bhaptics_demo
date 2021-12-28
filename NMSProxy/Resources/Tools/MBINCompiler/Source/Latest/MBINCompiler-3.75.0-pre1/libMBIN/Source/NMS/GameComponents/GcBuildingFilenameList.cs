﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x13200, GUID = 0x6B88307C9D36D6E4, NameHash = 0xC9E2EEA2B81DBE00)]
    public class GcBuildingFilenameList : NMSTemplate
    {
        [NMS(Size = 0x33, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        public GcBuildingFilename[] BuildingFiles;
    }
}
