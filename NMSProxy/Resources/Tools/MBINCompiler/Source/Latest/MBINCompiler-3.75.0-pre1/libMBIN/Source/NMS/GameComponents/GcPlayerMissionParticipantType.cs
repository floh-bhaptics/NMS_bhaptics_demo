﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0xDEE7950A004B0616, NameHash = 0x233DD65A730CE9DF)]
    public class GcPlayerMissionParticipantType : NMSTemplate
    {
		// size: 0xD
        public enum ParticipantTypeEnum { None, MissionGiver, MissionGiverReference, Primary, 
            Secondary1, Secondary2, Secondary3, Secondary4, Secondary5, Secondary6, Secondary7, Secondary8, Secondary9 
        }
		public ParticipantTypeEnum ParticipantType;
    }
}