﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0x2554D296719E9ED4, NameHash = 0xACDE6E8DA19EC2E2)]
    public class GcStatsEnum : NMSTemplate
    {
        // size: 0xF
		public enum GcStatEnumEnum {
            None, DEPOTS_BROKEN, FPODS_BROKEN, PLANTS_PLANTED, SALVAGE_LOOTED, TREASURE_FOUND, QUADS_KILLED, WALKERS_KILLED, FLORA_KILLED, PLANTS_GATHERED,
            BONES_FOUND, C_SENT_KILLS, STORM_CRYSTALS, BURIED_PROPS, MINIWORM_KILL
        }
		public GcStatEnumEnum GcStatEnum;
    }
}