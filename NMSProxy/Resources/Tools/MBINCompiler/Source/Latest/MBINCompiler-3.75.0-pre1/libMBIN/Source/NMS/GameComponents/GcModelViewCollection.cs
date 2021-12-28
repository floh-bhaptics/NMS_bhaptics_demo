﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x14A0, GUID = 0x668B6367DF4D3AF9, NameHash = 0xC3362B34D26192B6)]
    public class GcModelViewCollection : NMSTemplate
    {
        public enum ModelViewEnum {
            Suit, Weapon, Ship, Vehicle, DiscoveryMain, DiscoveryThumbnail, ToolboxMain, ToolboxThumbnail, TradeSuit,
            TradeShip, TradeCompareShips, TradeCompareWeapons, HUDThumbnail, Interaction, Freighter, TradeFreighter, TradeChest, TradeCapsule, TradeFrigate,
            TerrainBall, FreighterChest, Submarine, TradeCooker, SuitRefiner, FreighterRepair, DiscoveryPlanetaryMapping, Mech,
            PetThumbnail, PetThumbnailUI, PetLarge
        }
        [NMS(Size = 0x1E, EnumType = typeof(ModelViewEnum))]
        public TkModelRendererData[] ModelViews;
    }
}
