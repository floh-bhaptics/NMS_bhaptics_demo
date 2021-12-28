﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xB8, GUID = 0x8AAD82F7812779CF, NameHash = 0x66FAEFAF4E8E7167)]
    public class GcTradeData : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x10> AlwaysPresentProducts;
        /* 0x10 */ public List<NMSString0x10> AlwaysPresentSubstances;
        /* 0x20 */ public List<NMSString0x10> OptionalProducts;
        /* 0x30 */ public List<NMSString0x10> OptionalSubstances;

        /* 0x40 */ public int MinItemsForSale;
        /* 0x44 */ public int MaxItemsForSale;
        /* 0x48 */ public float PercentageOfItemsAreProducts;
        /* 0x4C */ public float BuyPriceIncreaseRedThreshold;
        /* 0x50 */ public float BuyPriceDecreaseGreenThreshold;
        /* 0x54 */ public float SellPriceIncreaseGreenThreshold;
        /* 0x58 */ public float SellPriceDecreaseRedThreshold;
        /* 0x5C */ public bool ShowSeasonRewards;
        [NMS(Size = 0x3, EnumType = typeof(GcWealthClass.WealthClassEnum))]
        /* 0x60 */ public int[] MinAmountOfProductAvailable;
        [NMS(Size = 0x3, EnumType = typeof(GcWealthClass.WealthClassEnum))]
        /* 0x6C */ public int[] MaxAmountOfProductAvailable;
        [NMS(Size = 0x3, EnumType = typeof(GcWealthClass.WealthClassEnum))]
        /* 0x78 */ public int[] MinAmountOfSubstanceAvailable;
        [NMS(Size = 0x3, EnumType = typeof(GcWealthClass.WealthClassEnum))]
        /* 0x84 */ public int[] MaxAmountOfSubstanceAvailable;
        [NMS(Size = 0x3, EnumType = typeof(GcWealthClass.WealthClassEnum))]
        /* 0x90 */ public int[] MinExtraSystemProducts;
        [NMS(Size = 0x3, EnumType = typeof(GcWealthClass.WealthClassEnum))]
        /* 0x9C */ public int[] MaxExtraSystemProducts;
        [NMS(Size = 0x3, EnumType = typeof(GcWealthClass.WealthClassEnum))]
        /* 0xA8 */ public float[] TradeProductsPriceImprovements;
    }
}
