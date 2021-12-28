﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x118, GUID = 0x1B1D3EF8AFB7C755, NameHash = 0xDE1F17CE7E01A8C2)]
    public class GcAlienPuzzleEntry : NMSTemplate
    {
        /* 0x000 */ public int ProgressionIndex;
        /* 0x004 */ public int MinProgressionForSelection;
        /* 0x008 */ public NMSString0x20A Id;
        /* 0x028 */ public GcAlienRace Race;
        /* 0x02C */ public GcInteractionType Type;
        /* 0x030 */ public GcAlienPuzzleCategory Category;
        public enum AdditionalOptionsEnum { None, LearnWord, SayWord }
        /* 0x034 */ public AdditionalOptionsEnum AdditionalOptions;
        /* 0x038 */ public NMSString0x20A Title;
        /* 0x058 */ public NMSString0x20A Text;
        /* 0x078 */ public NMSString0x20A TextAlien;
        /* 0x098 */ public bool TranslateAlienText;
        /* 0x099 */ public bool TranslationBrackets;
        /* 0x09A */ public bool ProgressiveDialogue;
        /* 0x0A0 */ public NMSString0x20A RequiresScanEvent;
        /* 0x0C0 */ public List<GcAlienPuzzleOption> Options;
        /* 0x0D0 */ public List<NMSString0x20A> AdditionalText;
        /* 0x0E0 */ public List<NMSString0x20A> AdditionalTextAlien;
        /* 0x0F0 */ public GcAlienMood Mood;
        /* 0x0F4 */ public GcNPCPropTypes Prop;
        /* 0x0F8 */ public List<GcPuzzleTextFlow> AdvancedInteractionFlow;
        public enum PersistancyBufferOverrideEnum { None, AlwaysPersonal, AlwaysFireteam }
        /* 0x108 */ public PersistancyBufferOverrideEnum PersistancyBufferOverride;
        /* 0x10C */ public int CustomFreighterTextIndex;
        /* 0x110 */ public bool RadialInteraction;
    }
}
