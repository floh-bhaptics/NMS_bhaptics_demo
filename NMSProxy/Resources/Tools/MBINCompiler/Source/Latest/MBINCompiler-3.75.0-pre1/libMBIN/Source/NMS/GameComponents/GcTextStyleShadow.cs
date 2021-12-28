﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0x7D59746106C3F196, NameHash = 0x28061A0FD187C5EF)]
    public class GcTextStyleShadow : NMSTemplate
    {
        public Colour ShadowColour;
        public Vector2f ShadowOffset;
    }
}