﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x60, GUID = 0xD1652C79D9419F1F, NameHash = 0xCBF9C66D539633AF)]
    public class GcAsteroidGeneratorSurround : NMSTemplate
    {
        public GcAsteroidGeneratorAssignment Assignment;
        public float LowerRadius;
        public float UpperRadius;
        public float NoiseOffset;
        public float NoiseScale;
        public float NoiseApply;
    }
}