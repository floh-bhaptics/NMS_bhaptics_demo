﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x118, GUID = 0x2A7E5A2390BD677B, NameHash = 0x7471FD77815538C2)]
    public class GcMissionSequenceReward : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Message;
        /* 0x080 */ public NMSString0x10 Reward;
        /* 0x090 */ public bool CanOverride;
        /* 0x091 */ public NMSString0x80 DebugText;
    }
}
