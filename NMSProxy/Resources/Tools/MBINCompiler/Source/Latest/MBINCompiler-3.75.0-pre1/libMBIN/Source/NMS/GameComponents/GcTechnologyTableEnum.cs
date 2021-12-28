﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x4, GUID = 0x92B0D75CF9321047, NameHash = 0xA32EA4A9B1B5B242)]
    public class GcTechnologyTableEnum : NMSTemplate
    {
        // size: 0x11B
        public enum gctechnologytableEnumEnum {
            None, PROTECT, UT_PROTECT, ENERGY, UT_ENERGY, JET1, UT_JET, UT_JUMP, UT_MIDAIR, UT_HOT,
            UT_COLD, UT_TOX, UT_RAD, UT_WATER, SUIT_REFINER, POWERGLOVE, ATLASSUIT, STARSUIT, OBSOLETE, UT_WATERJET,
            UT_WATERENERGY, UT_TRANSLATE1, UT_TRANSLATE2, UT_TRANSLATE3, STORY_TRANSLATE, WORMTECH, WORMREADER, SHIPJUMP1, UT_PULSEFUEL, UT_PULSESPEED,
            PHOTONIX_CORE, LAUNCHER, UT_LAUNCHER, UT_LAUNCHCHARGE, SHIP_TELEPORT, HYPERDRIVE, HDRIVEBOOST1, HDRIVEBOOST2, HDRIVEBOOST3, UT_QUICKWARP,
            SHIPSHIELD, UT_SHIPSHIELD, SHIPROCKETS, UT_ROCKETS, SHIPGUN1, UT_SHIPGUN, SHIPSCAN_ECON, SHIPSCAN_COMBAT, SHIPLAS1, UT_SHIPLAS,
            SHIPSHOTGUN, UT_SHIPSHOT, SHIPMINIGUN, UT_SHIPMINI, SHIPPLASMA, UT_SHIPBLOB, F_HYPERDRIVE, F_HDRIVEBOOST1, F_HDRIVEBOOST2, F_HDRIVEBOOST3,
            F_HACCESS1, F_HACCESS2, F_HACCESS3, F_TELEPORT, SHIPSLOT_DMG1, SHIPSLOT_DMG2, SHIPSLOT_DMG3, SHIPSLOT_DMG4, SHIPSLOT_DMG5, SHIPSLOT_DMG6,
            SHIPSLOT_DMG7, SHIPSLOT_DMG8, SHIPSLOT_DMG9, SHIPSLOT_DMG10, SHIPSLOT_DMG11, SHIPSLOT_DMG12, SHIPJUMP_ALIEN, LAUNCHER_ALIEN, WARP_ALIEN, SHIELD_ALIEN,
            SHIPGUN_ALIEN, SHIPLAS_ALIEN, T_BOBBLE_APOLLO, T_BOBBLE_ART, T_BOBBLE_ATLAS, T_BOBBLE_NADA, T_BOBBLE_NULL, T_BOBBLE_POLO, T_SHIP_RAINBOW, T_SHIP_DARK,
            T_SHIP_RED, T_SHIP_GREEN, T_SHIP_GOLD, LAUNCHER_SPEC, SHIPJUMP_SPEC, HYPERDRIVE_SPEC, SHIP_LIFESUP, SCANBINOC1, SCAN1, UT_SCAN,
            UT_SURVEY, TERRAINEDITOR, GROUND_SHIELD, SCOPE, LASER, STRONGLASER, UT_MINER, BOLT, UT_BOLT, UT_BOLTBOUNCE,
            BOLT_SM, LASER_XO, GRENADE, TERRAIN_GREN, RAILGUN, UT_RAIL, SHOTGUN, UT_SHOT, SMG, UT_SMG,
            UT_SMGBOUNCE, FLAME, WEAPSLOT_DMG1, WEAPSLOT_DMG2, WEAPSLOT_DMG3, WEAPSLOT_DMG4, WEAPSLOT_DMG5, WEAPSLOT_DMG6, WEAPSLOT_DMG7, WEAPSLOT_DMG8,
            WEAPSLOT_DMG9, WEAPSLOT_DMG10, WEAPSLOT_DMG11, WEAPSLOT_DMG12, SUN_LASER, SOUL_LASER, VEHICLE_ENGINE, VEHICLE_GRIP1, VEHICLE_GRIP2, VEHICLE_GRIP3,
            EXO_PROT_HOT, EXO_PROT_COLD, EXO_PROT_TOX, EXO_PROT_RAD, EXO_RECHARGE, VEHICLE_SCAN, VEHICLE_SCAN1, VEHICLE_SCAN2, VEHICLE_BOOST, VEHICLE_LASER,
            VEHICLE_LASER1, VEHICLE_GUN, SUB_ENGINE, SUB_GUN, SUB_LASER, SUB_BINOCS, SUB_RECHARGE, MECH_ENGINE, MECH_FUEL, MECH_SCAN,
            MECH_BOOST, MECH_LASER, MECH_LASER1, MECH_GUN, MECH_MINER, MECH_PROT, MAINT_FARM1, MAINT_FARM2, MAINT_FARM3, MAINT_FARM4,
            MAINT_FARM5, MAINT_FUEL1, MAINT_FUEL2, MAINT_FUEL3, MAINT_FUEL4, MAINT_FUEL5, MAINT_TECH1, MAINT_TECH2, MAINT_TECH3, MAINT_TECH4,
            MAINT_TECH5, MAINT_TECH6, MAINT_TECH7, MAINT_TECH8, MAINT_TECH9, MAINT_TECH10, MAINT_TECH11, MAINT_TECH12, MAINT_TECH13, MAINT_TECH14,
            MAINT_TECH15, MAINT_TECH16, MAINT_TECH17, MAINT_TECH18, MAINT_TECH19, MAINT_TECH20, MAINT_TECH21, MAINT_TECH22, MAINT_TECH23, MAINT_TECH24,
            MAINT_TECH25, MAINT_PORTAL1, MAINT_PORTAL2, MAINT_PORTAL3, MAINT_PORTAL4, MAINT_PORTAL5, MAINT_PORTAL6, MAINT_PORTAL7, MAINT_PORTAL8, MAINT_PORTAL9,
            MAINT_PORTAL10, MAINT_PORTAL11, MAINT_PORTAL12, MAINT_PORTAL13, MAINT_PORTAL14, MAINT_PORTAL15, MAINT_PORTAL16, MAINT_REFINER, MAINT_BURNER, MAINT_ARTIFACT,
            MAINT_SEALOCK1, MAINT_SEALOCK2, MAINT_FRIG1, MAINT_FRIG2, MAINT_FRIG3, MAINT_FRIG4, MAINT_FRIG5, MAINT_FRIG6, MAINT_FRIG7, MAINT_FRIG8,
            MAINT_FRIG9, MAINT_FRIG10, EXOPOD_TECH1, EXOPOD_TECH2, EXOPOD_TECH3, T_SHIPJUMP, T_LAUNCHER, T_HDRIVE, T_SHIPSHLD, T_SHIPGUN,
            T_SHIPLAS, T_SHIPSHOT, T_SHIPMINI, T_SHIPBLOB, T_SCAN, T_LASER, T_BOLT, T_GRENADE, T_T_GREN, T_RAIL,
            T_SHOTGUN, T_SMG, T_ENERGY, T_JET, T_SHIELD, T_HAZ, T_UNW, T_RAD, T_TOX, T_COLDPROT,
            T_HOTPROT, T_EXGUN, T_EXLAS, T_BOOST, T_EXENG, T_SUB, T_SUBGUN, A_SHIPJUMP, A_LAUNCH, A_HDRIVE,
            A_SHIPSHLD, A_SHIPGUN, A_SHIPLAS, T_MCGUN, T_MCLAS, T_MCENG, T_FR_HYP, T_FR_SPEED, T_FR_FUEL, T_FR_TRADE,
            T_FR_COM, T_FR_EXP, T_FR_MINE
        }
        public gctechnologytableEnumEnum gctechnologytableEnum;
    }
}