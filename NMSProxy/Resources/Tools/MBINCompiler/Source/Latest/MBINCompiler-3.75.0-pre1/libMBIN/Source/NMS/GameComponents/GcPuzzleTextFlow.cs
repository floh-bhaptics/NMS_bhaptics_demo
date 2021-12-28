﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x50, GUID = 0xAD97AE8724BF862B, NameHash = 0x44CB81CE83D73B16)]
    public class GcPuzzleTextFlow : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A Text;
        /* 0x20 */ public bool IsAlien;
        /* 0x28 */ public NMSString0x20A Title;
        /* 0x48 */ public GcAlienMood Mood;
    }
}
