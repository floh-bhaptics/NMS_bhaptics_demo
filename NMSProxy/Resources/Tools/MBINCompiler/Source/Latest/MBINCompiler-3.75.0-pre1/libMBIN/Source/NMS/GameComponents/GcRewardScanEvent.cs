﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x28, GUID = 0xC4540B52B2725A62, NameHash = 0xD6D2BF5DDCCD9F49)]
    public class GcRewardScanEvent : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A Event;
		public enum ScanEventTableEnum { Space, Planet, Missions, Tutorial, MissionsCreative, NPCPlanetSite }
		/* 0x20 */ public ScanEventTableEnum ScanEventTable;
        /* 0x24 */ public bool DoAerialScan;
        /* 0x25 */ public bool UseMissionSeedForEvent;
    }
}
