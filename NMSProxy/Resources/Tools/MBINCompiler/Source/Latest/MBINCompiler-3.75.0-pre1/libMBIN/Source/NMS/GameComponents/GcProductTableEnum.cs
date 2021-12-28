﻿using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x4, GUID = 0x4BC4289854625B33, NameHash = 0xBD7214A930BFF3F2)]
    public class GcProductTableEnum : NMSTemplate
    {
        // size: 0x6F1
        public enum gcproducttableEnumEnum {
            None, CASING, NANOTUBES, CARBON_SEAL, MICROCHIP, HYDRALIC, COMPUTER, MAGNET, MIRROR, BIO, TECH_COMP, REPAIRKIT, PRODFUEL2, POWERCELL,
            SHIPCHARGE, JELLY, LAUNCHFUEL, SUBFUEL, GRENFUEL1, AMMO, AM_HOUSING, ANTIMATTER, HYPERFUEL1, HYPERFUEL2, QUAD_PROD, WALKER_PROD,
            GEODE_LAND, GEODE_CAVE, GEODE_CRYSTAL, GEODE_SPACE, GEODE_ASTEROID, GEODE_RARE, SCRAP_GOODS, SCRAP_TECH, SCRAP_WEAP, POI_LOCATOR,
            ABAND_LOCATOR, ABAND_LOCATOR_X, SACVENOM, GRAVBALL, ALBUMENPEARL, CAVECUBE, FIENDCORE, STORM_CRYSTAL, CLAMPEARL, VENTGEM, FISHCORE,
            EYEBALL, ALLOY1, ALLOY2, ALLOY3, ALLOY4, ALLOY5, ALLOY6, ALLOY7, ALLOY8, STARCHART_A, STARCHART_B, STARCHART_C, STARCHART_D,
            CHART_EMPTY, A1S6_STARMAP, TUT_STARMAP, CHART_TREASURE, CHART_SETTLE, ARTIFACT_KEY, TRIDENT_KEY, WAR_CURIO3, EXP_CURIO3, STATION_KEY,
            NAV_DATA, NAV_DATA_DROP, LOG_KEY, ACCESS1, ACCESS2, ACCESS3, POLICE_TOKEN, MIND_ARC, SOUL_ENGINE, BP_SALVAGE, FACT_TOKEN, FRIG_TOKEN,
            SHIP_INV_TOKEN, FREI_INV_TOKEN, WEAP_INV_TOKEN, SUIT_INV_TOKEN, FRIGATE_FUEL_1, FRIGATE_FUEL_2, FRIGATE_FUEL_3, FRIG_BOOST_TRA,
            FRIG_BOOST_EXP, FRIG_BOOST_MIN, FRIG_BOOST_COM, FRIG_BOOST_SPD, TRA_CURIO1, TRA_CURIO2, NIPNIPBUDS, WAR_CURIO1, WAR_CURIO2,
            EXP_CURIO1, EXP_CURIO2, WORMBOOK, WORMSCROLL1, WORMSCROLL2, WORMSCROLL3, WORMSCROLL4, WORMSCROLL5, WORMCORE, WORMPROD, FARMPROD1,
            FARMPROD2, FARMPROD3, FARMPROD4, FARMPROD5, FARMPROD6, FARMPROD7, FARMPROD8, FARMPROD9, REACTION1, REACTION2, REACTION3, COMPOUND1,
            COMPOUND2, COMPOUND3, COMPOUND4, COMPOUND5, COMPOUND6, MEGAPROD1, MEGAPROD2, MEGAPROD3, ULTRAPROD1, ULTRAPROD2, TRA_ALLOY1,
            TRA_ALLOY2, TRA_ALLOY3, TRA_ALLOY4, TRA_ALLOY5, TRA_COMMODITY1, TRA_COMMODITY2, TRA_COMMODITY3, TRA_COMMODITY4, TRA_COMMODITY5,
            TRA_COMPONENT1, TRA_COMPONENT2, TRA_COMPONENT3, TRA_COMPONENT4, TRA_COMPONENT5, TRA_ENERGY1, TRA_ENERGY2, TRA_ENERGY3, TRA_ENERGY4,
            TRA_ENERGY5, TRA_EXOTICS1, TRA_EXOTICS2, TRA_EXOTICS3, TRA_EXOTICS4, TRA_EXOTICS5, TRA_MINERALS1, TRA_MINERALS2, TRA_MINERALS3,
            TRA_MINERALS4, TRA_MINERALS5, TRA_TECH1, TRA_TECH2, TRA_TECH3, TRA_TECH4, TRA_TECH5, ATLAS_STONE, ATLAS_SEED_1, ATLAS_SEED_2,
            ATLAS_SEED_3, ATLAS_SEED_4, ATLAS_SEED_5, ATLAS_SEED_6, ATLAS_SEED_7, ATLAS_SEED_8, ATLAS_SEED_9, ATLAS_SEED_10, HEXCORE, SALVAGE_TECH1,
            SALVAGE_TECH2, SALVAGE_TECH3, SALVAGE_TECH4, SALVAGE_TECH5, SALVAGE_TECH6, SALVAGE_TECH7, SALVAGE_TECH8, SALVAGE_TECH9, SALVAGE_TECH10,
            BIOSHIP_STEM1, BIOSHIP_STEM2, BIOSHIP_STEM3, BIOSHIP_STEM4, BIOSHIP_GROWTH1, BIOSHIP_GROWTH2, BIOSHIP_GROWTH3, BIOSHIP_GROWTH4,
            BIOSHIP_EGG1, BIOSHIP_EGG2, BIOSHIP_EGG3, BIOSHIP_EGG4, BIOSHIP_EGG5, BIOSHIP_COMP1, BIOSHIP_COMP2, BIOSHIP_COMP3, BIOSHIP_COMP4,
            BIOSHIP_COMP5, BIOSHIP_COMP5_0, BIOSHIP_COMP5_1, BIOSHIP_COMP5_2, EXOTIC_BIOPROD, MP_REP_PART1, MP_REP_PART1B, MP_REP_PART1C,
            MP_REP_PART2, MP_REP_PART2B, MP_REP_PART2C, MP_REP_PART3, MP_REP_PART3B, MP_REP_PART3C, TITLE_UNLOCK, EGG1, EGG2, EGG3, EGG4,
            EGG5, EGG6, FUELPROD3, LANDPROD3, CAVEPROD3, WATERPROD3, CATAPROD3, OXYPROD3, OXY_CRAFT, WATER_CRAFT, CAVE_CRAFT, CATA_CRAFT,
            PRODFUEL1, POWERCELL2, FREIGHT_PAINT, FREIGHT_RED, FREIGHT_ORANGE, FREIGHT_YELLOW, FREIGHT_GREEN, FREIGHT_CYAN, FREIGHT_BLUE,
            FREIGHT_PURPLE, FREIGHT_PINK, FREIGHT_WHITE, FREIGHT_BLACK, FOUNDATION, CORRIDOR, CORRIDORL, CORRIDORT, CORRIDORX, MAINROOM,
            FOUNDLEG4, FOUNDLEG, BUILDTOWER, CUBEROOM, CUBEFOUND, CUBEFOUND4, CUBEFLOOR, GLASSCORRIDOR, BUILDRAMP, BIOROOM, CURVEDCUBEROOF,
            CUBEROOMCURVED, CUBEGLASS, CUBEFRAME, CUBEINNERDOOR, CUBEWALL, CUBEROOF, CUBESTAIRS, BUILDDOOR, DOOR2, VIEWSPHERE, MAINROOMFRAME,
            CORRIDORC, MAINROOMCUBE, MAINROOMCUBEF, BASE_FLAG, BUILDLANDINGPAD, BUILDTERMINAL, HEALTHSTATION, SHIELDSTATION, BUILDSAVE,
            BUILDBEACON, BUILDSIGNAL, BUILDANTIMATTER, TELEPORTER, TELEPORTER_F, BASECAPSULE, NPCFRIGTERM, BP_ANALYSER, BUILD_REFINER1,
            BUILD_REFINER2, BUILD_REFINER3, DRESSING_TABLE, COOKER, CREATURE_FEED, CREATURE_FARM, SHIPSUMMON, MESSAGEMODULE, MESSAGE, GARAGE_S,
            GARAGE_M, GARAGE_L, GARAGE_B, GARAGE_SUB, SUMMON_GARAGE, GARAGE_MECH, GARAGE_FREIGHT, NPCSCIENCETERM, NPCWEAPONTERM, NPCFARMTERM,
            NPCVEHICLETERM, NPCBUILDERTERM, PLANTER, PLANTERMEGA, TOXICPLANT, SNOWPLANT, RADIOPLANT, BARRENPLANT, LUSHPLANT, SCORCHEDPLANT,
            CREATUREPLANT, POOPPLANT, GRAVPLANT, SACVENOMPLANT, PEARLPLANT, NIPPLANT, CARBONPLANTER, CONTAINER0, CONTAINER1, CONTAINER2,
            CONTAINER3, CONTAINER4, CONTAINER5, CONTAINER6, CONTAINER7, CONTAINER8, CONTAINER9, WALLLIGHTBLUE, WALLLIGHTPINK, WALLLIGHTYELLOW,
            WALLLIGHTGREEN, WALLLIGHTRED, WALLLIGHTWHITE, SMALLLIGHT, BUILDLIGHT, BUILDLIGHT2, BUILDLIGHT3, LIGHTBOX, L_FLOOR_Q, CEILINGLIGHT,
            BUILDPAVING, BUILDPAVING_BIG, BUILDPAVINGTALL, BUILDLADDER, CUBELADDER, BUILDWINDOW, CUBEWINDOW, WALLDOOR, WALLFLOORLADDER,
            CUBEWINDOWOVAL, CUBEWINDOWSMALL, BUILDCHAIR, BUILDCHAIR2, BUILDCHAIR3, BUILDSOFA, BUILDSOFA2L, BUILDSOFA2, BUILDTABLE, BUILDTABLE2,
            BUILDBED, LARGEDESK, BUILDSIMPLEDESK, CURVEDDESK, MONITORDESK, BUILDLIGHTTABLE, BUILDWORKTOP, PLANTPOT, PLANTPOT1, PLANTPOT2,
            PLANTPOT3, CHEST, BLDWALLUNIT, DRAWS, STORAGEPANEL, SHELFPANEL, OCTACABINET, BUILDAMCRATE, CRATELRARE, CRATELCYLINDER, BUILDLCRATE,
            BUILDHCABINET, BUILDLOCKER, BUILDSIDEPANEL, FLOORMAT1, FLAG1, FLAG2, FLAG3, FLAG4, WALLFLAG1, WALLFLAG2, WALLFLAG3, TECHPANEL,
            WALLFAN, WALLSCREEN, SERVERSTACK, ROOFMONITOR, WEAPONRACK, BUILDCANRACK, ROBOTICARM, BUILDFLATPANEL, BOXEDSCREEN, WALLSCREENB,
            WALLSCREENB2, BUILDLABLAMP, WEDGESHAPE, WEDGESMALLSHAPE, PYRAMIDSHAPE, CURVEPIPESHAPE, PIPESHAPE, PIPE, CUBESOLID, CYLINDERSHAPE,
            CUBESHAPE, SPHERESHAPE, BUILDTABLE3, WALL, CORNERPOST, ROOMFLOOR, WALLTALL, WALLCURVED, CUBEROOM_SPACE, CUBEROOMB_SPACE, CUBEROOMC_SPACE,
            BRIDGECONNECTOR, CORRIDOR_SPACE, CORRIDORL_SPACE, CORRIDORT_SPACE, CORSTAIRS_SPACE, CUBEWALL_SPACE, CORRIDORX_SPACE, S_CONTAINER0,
            S_CONTAINER1, S_CONTAINER2, S_CONTAINER3, S_CONTAINER4, S_CONTAINER5, S_CONTAINER6, S_CONTAINER7, S_CONTAINER8, S_CONTAINER9,
            RACE_START, RACE_START_SHIP, RACE_BOOSTER, RACE_RAMP, BUILDDECAL, BUILDDECAL2, BUILDDECALNMS, BUILDDECALNUM0, BUILDDECALNUM1,
            BUILDDECALNUM2, BUILDDECALNUM3, BUILDDECALNUM4, BUILDDECALNUM5, BUILDDECALNUM6, BUILDDECALNUM7, BUILDDECALNUM8, BUILDDECALNUM9,
            BUILDDECALVIS1, BUILDDECALVIS2, BUILDDECALVIS3, BUILDDECALVIS4, BUILDDECALVIS5, BUILDDECALSIMP1, BUILDDECALSIMP2, BUILDDECALSIMP3,
            BUILDDECALSIMP4, CORRIDOR_WINDOW, HEALTHPLANT, NPCEXPLORER001, CREATHOLOGRAM, CORRIDOR_WATER, CORRIDORL_WATER, CORRIDORT_WATER,
            CORRIDORX_WATER, CORRIDORV_WATER, MAINROOM_WATER, MAINROOMCUBE_W, PANEL_GLASS, WATERBUBBLE, MOONPOOL, BUILDDOOR_WATER, BASE_ENGINEORB,
            BASE_BEAMSTONE, BASE_BUBBLECLUSTER, BASE_MEDGEOMETRIC, BASE_SHARD, BASE_STARJOINT, BASE_BONEGARDEN, BASE_CONTOURPOD, BASE_HYDROPOD,
            BASE_SHELLWHITE, BASE_WEIRDCUBE, SPAWNER_BALL, NOISEBOX, BYTEBEAT, MEDTUBE, HEATER, FOORLIGHT, PLANTTUBE, LOCKER2, ABAND_SHELF,
            ABAND_CRATE_M, ABAND_CRATE_L, ABAND_CRATE_XL, ABAND_CASE, FOOTLOCKER, ABAND_BENCH, PALLET, ABAND_BARREL, M_WALL, M_WALL_H, M_WALL_Q,
            M_WALL_Q_H, M_WALLDIAGONAL, M_WALL_WINDOW, M_SDOOR, M_DOOR, M_DOOR_H, M_GDOOR, M_GDOOR_D, M_DOORWINDOW, M_FLOOR, M_TRIFLOOR,
            M_TRIFLOOR_Q, M_GFLOOR, M_FLOOR_Q, M_RAMP, M_RAMP_H, M_ROOF, M_ROOF_M, M_ROOF_C, M_ROOF_IC, M_ARCH, M_ARCH_H, C_WALL, C_WALL_H,
            C_WALL_Q, C_WALL_Q_H, C_WALLDIAGONAL, C_WALL_WINDOW, C_DOOR, C_SDOOR, C_DOOR_H, C_GDOOR, C_GDOOR_D, C_DOORWINDOW, C_FLOOR, C_TRIFLOOR,
            C_TRIFLOOR_Q, C_GFLOOR, C_FLOOR_Q, C_RAMP, C_RAMP_H, C_ROOF, C_ROOF_M, C_ROOF_C, C_ROOF_IC, C_ARCH, C_ARCH_H, W_WALL, W_WALL_H,
            W_WALL_Q, W_WALL_Q_H, W_WALLDIAGONAL, W_WALL_WINDOW, W_SDOOR, W_DOOR, W_DOOR_H, W_GDOOR, W_GDOOR_D, W_DOORWINDOW, W_FLOOR, W_TRIFLOOR,
            W_TRIFLOOR_Q, W_GFLOOR, W_FLOOR_Q, W_RAMP, W_RAMP_H, W_ROOF, W_ROOF_M, W_ROOF_C, W_ROOF_IC, W_ARCH, W_ARCH_H, O2_HARVESTER,
            BUILDHARVESTER, BUILDGASHARVESTER, SET_CONSTRUCT, SET_GROUNDDECAL, SET_MAYORTERM, SET_MONUMENT, SET_MONUMENT_FA, SET_SFXCONST_S0,
            SET_SFXCONST_S1, SET_SFXCONST_S2, SET_S_TOWER, SET_S_TOWER_FA, S_LANDINGZONE, SET_T_MONU, SET_T_MONU_FA, SET_F_MONU, SET_F_MONU_FA,
            S_CANOPY_WALL0, S_CANOPY_WALL1, S_CANOPY_WALL2, S_WALL_SUPPORTS, S_WATERTOWER, S_ANTENNA0, S_ANTENNA1, S_ANTENNA2, S_FLAG5,
            S_FLAG6, S_RUG0, S_POT0, S_CHAIR0, S_BARTABLE0, S_WALLLIGHT0, S_BAR_H, S_BAR, S_BAR_C, S_TABLEPOT0, S_TABLELAMP0, S_CUP0, S_TRAY0,
            S_CRATE0, S_BURNER0, S_PAN0, S_BARSTOOL0, S_CANISTER0, S_BARTAPS0, S_WALLHANGING1, S_WALLHANGING2, S_WALLHANGING3, S_PLANTER_M,
            S_SIGN_BAR0, S_STEPLADDER, S_SCAFFOLD_M, S_SCAFFOLD_L, S_BUCKET_S, S_BUCKET_M, S_PALLET, S_PALLET_BRICK, S_CEMENTBAG, S_BARRIER,
            S_RSJSTACK, S_CEMENTMIXER, S_SHOVEL, S_BRICKSWRAPPED, S_LARGETRYE0, S_COMPOSTBIN, S_FURNACE, S_WHEELBARROW, S_EXCBUCKET, S_TROUGH0,
            S_MILKCRATE, S_MILKBOTTLE, S_BARREL1, S_SPARKPLUG, S_CARRIAGE, S_CARRIAGEWHEEL, S_SCISSORLIFT, S_PUMP, S_GENERATOR, S_CRATE1,
            S_CRATE2, S_CANISTER1, S_FENCE0, S_FENCE1, S_FENCE2, S_FENCE3, S_HANGLAMP0, S_CURTAIN0, S_GLOWGLOBE, S_DRAPE0, S_RUG1, S_STREETLAMP0,
            S_LIGHTSTRIP0, S_SHELVINGUNIT0, S_GAZEBO0, S_CRATE3, S_CRATE3OPEN, S_CRATE4, S_CRATE4OPEN, S_FABROLL0, S_FABROLLPILE0, S_WATERVALVE0,
            S_MACHINE0, S_ANTENNA3, S_POSTER0, S_POSTER1, S_POSTER2, S_POSTER3, S_POSTER4, S_POSTER5, S_POSTER6, S_POSTER7, S_POSTER8, S_POSTER9,
            S_POSTER10, S_POSTER11, S_POSTER13, S_POSTER15, S_HANGLAMP1, S_HANGLAMP2, S_HANGLAMP3, S_WALL, S_WALLB, S_WALLM, S_WALLT, S_WALL_H,
            S_WALLB_H, S_WALLM_H, S_WALLT_H, S_WALL_Q, S_WALL_Q1, S_WALL_Q_H, S_WALL_Q_H1, S_WALLDIAGONAL, S_WALLB_TRI, S_WALLM_TRI, S_WALLT_TRI,
            S_WALL_WINDOW, S_WALLB_WIN0, S_WALLM_WIN0, S_WALLT_WIN0, S_WALL_WIN1, S_WALLB_WIN1, S_WALLM_WIN1, S_WALLT_WIN1, S_WALL_WIN2,
            S_WALLB_WIN2, S_WALLM_WIN2, S_WALLT_WIN2, S_WALL_WIN3, S_WALLB_WIN3, S_WALLM_WIN3, S_WALLT_WIN3, S_DOOR, S_DOORB0, S_DOORM0,
            S_DOORT0, S_DOOR1, S_DOORB1, S_DOORM1, S_DOORT1, S_FLOOR, S_FLOOR_Q, S_TRIFLOOR, S_TRIFLOOR_Q, S_GFLOOR, S_RAMP, S_RAMP_H, S_ROOF0,
            S_ROOF1, S_ROOF2, S_ROOF3, S_ROOF4, S_ROOF5, S_ROOF_M, S_ROOF_C, S_ROOF_IC, S_CHEV_WALL, S_CHEV_DOOR, S_CHEV_WALL_H_C, S_CHEV_WIN0,
            S_CHEV_WIN1, S_CHEV_WIN2, S_ROOF_M_Q, S_ROOF_E_Q, S_ROOF_M_CAP, S_ROOF_E_CAP, S_DOOR_H, S_DOORB0_H, S_DOORM0_H, S_DOORT0_H,
            S_DOORWINDOW, S_DOORWINB0, S_DOORWINM0, S_DOORWINT0, S_GDOOR, S_GDOORB0, S_GDOORM0, S_GDOORT0, S_ARCH, S_ARCHB, S_ARCHM, S_ARCHT,
            S_ARCH_H, S_ARCHB_H, S_ARCHM_H, S_ARCHT_H, S_RAMP_Q_TOP, T_WALL, T_WALLB, T_WALLM, T_WALLT, T_WALL_H, T_WALLB_H, T_WALLM_H,
            T_WALLT_H, T_WALL_Q, T_WALL_Q1, T_WALL_Q_H, T_WALL_Q_H1, T_WALLDIAGONAL, T_WALLB_TRI, T_WALLM_TRI, T_WALLT_TRI, T_WALL_WINDOW,
            T_WALLB_WIN0, T_WALLM_WIN0, T_WALLT_WIN0, T_WALL_WIN1, T_WALLB_WIN1, T_WALLM_WIN1, T_WALLT_WIN1, T_WALL_WIN2, T_WALLB_WIN2,
            T_WALLM_WIN2, T_WALLT_WIN2, T_WALL_WIN3, T_WALLB_WIN3, T_WALLM_WIN3, T_WALLT_WIN3, T_DOOR, T_DOORB0, T_DOORM0, T_DOORT0, T_DOOR1,
            T_DOORB1, T_DOORM1, T_DOORT1, T_FLOOR, T_FLOOR_Q, T_TRIFLOOR, T_TRIFLOOR_Q, T_GFLOOR, T_RAMP, T_RAMP_H, T_ROOF0, T_ROOF1, T_ROOF2,
            T_ROOF3, T_ROOF4, T_ROOF5, T_ROOF6, T_ROOF7, T_ROOF_M, T_ROOF_C, T_ROOF_IC, T_CHEV_WALL, T_CHEV_DOOR, T_CHEV_WALL_H_C, T_CHEV_WIN0,
            T_CHEV_WIN1, T_CHEV_WIN2, T_ROOF_M_Q, T_ROOF_E_Q, T_ROOF_M_CAP, T_ROOF_E_CAP, T_DOOR_H, T_DOORB0_H, T_DOORM0_H, T_DOORT0_H,
            T_DOORWINDOW, T_DOORWINB0, T_DOORWINM0, T_DOORWINT0, T_GDOOR, T_GDOORB0, T_GDOORM0, T_GDOORT0, T_ARCH, T_ARCHB, T_ARCHM, T_ARCHT,
            T_ARCH_H, T_ARCHB_H, T_ARCHM_H, T_ARCHT_H, T_RAMP_Q_TOP, F_WALL, F_WALLB, F_WALLM, F_WALLT, F_WALL_H, F_WALLB_H, F_WALLM_H,
            F_WALLT_H, F_WALL_Q, F_WALL_Q1, F_WALL_Q_H, F_WALL_Q_H1, F_WALLDIAGONAL, F_WALLB_TRI, F_WALLM_TRI, F_WALLT_TRI, F_WALL_WINDOW,
            F_WALLB_WIN0, F_WALLM_WIN0, F_WALLT_WIN0, F_WALL_WIN1, F_WALLB_WIN1, F_WALLM_WIN1, F_WALLT_WIN1, F_WALL_WIN2, F_WALLB_WIN2,
            F_WALLM_WIN2, F_WALLT_WIN2, F_WALL_WIN3, F_WALLB_WIN3, F_WALLM_WIN3, F_WALLT_WIN3, F_DOOR, F_DOORB0, F_DOORM0, F_DOORT0, F_DOOR1,
            F_DOORB1, F_DOORM1, F_DOORT1, F_FLOOR, F_FLOOR_Q, F_TRIFLOOR, F_TRIFLOOR_Q, F_GFLOOR, F_RAMP, F_RAMP_H, F_ROOF0, F_ROOF1, F_ROOF2,
            F_ROOF3, F_ROOF4, F_ROOF5, F_ROOF6, F_ROOF7, F_ROOF8, F_ROOF_M, F_ROOF_C, F_ROOF_IC, F_CHEV_WALL, F_CHEV_DOOR, F_CHEV_WALL_H_C,
            F_CHEV_WIN0, F_CHEV_WIN1, F_CHEV_WIN2, F_ROOF_M_Q, F_ROOF_E_Q, F_ROOF_M_CAP, F_ROOF_E_CAP, F_DOOR_H, F_DOORB0_H, F_DOORM0_H,
            F_DOORT0_H, F_DOORWINDOW, F_DOORWINB0, F_DOORWINM0, F_DOORWINT0, F_GDOOR, F_GDOORB0, F_GDOORM0, F_GDOORT0, F_ARCH, F_ARCHB,
            F_ARCHM, F_ARCHT, F_ARCH_H, F_ARCHB_H, F_ARCHM_H, F_ARCHT_H, F_RAMP_Q_TOP, U_EXTRACTOR_S, U_GASEXTRACTOR, U_SILO_S, U_SOLAR_S,
            U_GENERATOR_S, U_BIOGENERATOR, U_POWERLINE, U_PORTALLINE, U_BYTEBEATLINE, U_SWITCHWALL, U_SWITCHPRESS, U_BATTERY_S, U_SWITCHBUTTON,
            U_SWITCHPROX, U_PIPELINE, U_TRANSISTOR1, U_TRANSISTOR2, U_MINIPORTAL, BYTEBEATSWITCH, POWERLINE_HIDER, SPEC_XOHELMET, SPEC_DIVEHELMET,
            EXPD_BACKPACK01, EXPD_HELMET01, EXPD_SHIP01, EXPD_TITLE01, EXPD_DECAL01, EXPD_BANNER01, EXPD_FIREPACK01, EXPD_FIREWORK01, EXPD_FIREWORK02,
            EXPD_FIREWORK03, EXPD_FIREWORK04, EXPD_FIREPACK04, BLD_EXPD_BASE01, EXPD_SPEC02, MYSTERY_TRACKER, EXPD_TITLE02A, EXPD_TITLE02B,
            EXPD_DECAL02, EXPD_BANNER02, BLD_PLANET_HOLO, BLD_FLYJAR, EXPD_TITLE03, EXPD_DECAL03, EXPD_BANNER03, EXPD_TITLE04, EXPD_DECAL04,
            EXPD_BANNER04, JETS_BUBBLE, JETS_WORM, EXPD_EGG_03, EXPD_EGG_04, BLD_SKULL, EXPD_WORMHAT, TWITCH_SHIP01, TWITCH_SHIP02, TWITCH_SHIP03,
            TWITCH_SHIP04, TWITCH_SHIP05, TWITCH_SHIP06, TWITCH_SHIP07, TWITCH_SHIP08B, TWITCH_SHIP09, TWITCH_SHIP10, TWITCH_PET01, TWITCH_PET02,
            TWITCH_PET03, TWITCH_PET04, TWITCH_PET05, TWITCH_GUN01, TWITCH_GUN02, TWITCH_GUN03, TWITCH_GUN04, TWITCH_GUN05, TWITCH_GUNUP01A,
            TWITCH_GUNUP01B, TWITCH_GUNUP01C, TWITCH_GUNUP01D, TWITCH_GUNUP01E, TWITCH_FIREW01A, TWITCH_FIREW01B, TWITCH_FIREW01C, TWITCH_FIREW01D,
            TWITCH_FIREW01E, TWITCH_FIREW02A, TWITCH_FIREW02B, TWITCH_FIREW02C, TWITCH_FIREW02D, TWITCH_FIREW02E, STATUE_BLOB_B, STATUE_BLOB_S,
            STATUE_BLOB_G, STATUE_DIP_B, STATUE_DIP_S, STATUE_DIP_G, STATUE_GEK_B, STATUE_GEK_S, STATUE_GEK_G, STATUE_SHIP_B, STATUE_SHIP_S,
            STATUE_SHIP_G, STATUE_WALK_B, STATUE_WALK_S, STATUE_WALK_G, STATUE_ATLAS_B, STATUE_ATLAS_S, STATUE_ATLAS_G, STATUE_ASTRO_B,
            STATUE_ASTRO_S, STATUE_ASTRO_G, SPEC_EMOTE01, SPEC_EMOTE02, SPEC_EMOTE03, SPEC_EMOTE04, SPEC_EMOTE05, SPEC_EMOTE08, SPEC_EMOTE09,
            SPEC_EMOTE10, SPEC_DECAL01, SPEC_DECAL02, SPEC_DECAL03, SPEC_DECAL04, SPEC_DECAL05, SPEC_DECAL06, SPEC_DECAL07, SPEC_DECAL08,
            DECAL_HAZARD, DECAL_SKULL, DECAL_HORROR, DECAL_JELLY, DECAL_AGT, DECAL_AMINO, DECAL_CAFE, DECAL_UFT, DECAL_QIT, DECAL_BIOME3,
            DECAL_CPLANET1, DECAL_STARTSHIP, DECAL_GALCORE, DECAL_UWTREAS, DECAL_NEXUSM, SPEC_HELMET01, SPEC_HELMET02, SPEC_HELMET03, SPEC_HELMET05,
            SPEC_VYK_ARMOUR, SPEC_VYK_TORSO, SPEC_VYK_GLOVES, SPEC_VYK_LEGS, SPEC_VYK_BOOTS, SPEC_EXOTIC1, SPEC_EXOTIC2, SPEC_EXOTIC3, SPEC_EXOTIC4,
            SPEC_EXOTIC5, SPEC_EXOTIC6, SPEC_EXOTIC7, SPEC_EXOTIC8, SPEC_EXOTIC9, SPEC_EXOTIC10, SPEC_EXOTIC11, SPEC_EXOTIC12, SPEC_SPOOKYHEAD,
            NEW_BACKPACK, BOBBLE_APOLLO, BOBBLE_ART, BOBBLE_ATLAS, BOBBLE_NADA, BOBBLE_NULL, BOBBLE_POLO, JETS_RAINBOW, JETS_DARK, JETS_RED,
            JETS_GREEN, JETS_BLUE, SHIP_RAINBOW, SHIP_DARK, SHIP_RED, SHIP_GREEN, SHIP_GOLD, BASE_ROBOTOY, BASE_TOYCUBE, BASE_TOYSPHERE,
            BASE_TOYJELLY, BASE_TREE01, BASE_TREE02, BASE_TREE03, BASE_MEDPLANT01, BASE_MEDPLANT02, BASE_MEDPLANT03, BASE_AQUARIUM, BASE_WPLANT1,
            BASE_WPLANT2, BASE_WPLANT3, BASE_BARNACLE, SPEC_FIREWORK01, SPEC_FIREWORK02, SPEC_FIREWORK03, SPEC_FIREWORK04, SPEC_FIREWORK05,
            SPEC_FIREWORK06, BASE_TOYCORE, BASE_TERRARIUM, BASE_HOTPLANT01, BASE_HOTPLANT02, BASE_HOTPLANT03, BASE_RADPLANT01, BASE_RADPLANT02,
            BASE_RADPLANT03, BASE_TOXPLANT01, BASE_TOXPLANT02, BASE_TOXPLANT03, BASE_DUSTPLANT1, BASE_DUSTPLANT2, BASE_DUSTPLANT3, BASE_COLDPLANT1,
            BASE_COLDPLANT2, BASE_COLDPLANT3, BASE_ROCK01, BASE_ROCK02, BASE_ROCK03, BASE_SWAMP1, BASE_SWAMP2, BASE_SWAMP3, BASE_HOUDINI1,
            BASE_HOUDINI2, BASE_HOUDINI3, BASE_INFEST1, BASE_INFEST2, BASE_INFEST3, BASE_LAVA1, BASE_LAVA2, BASE_LAVA3, BASE_CAVE1, BASE_CAVE2,
            BASE_CAVE3, BASE_CAVE4, BASE_CAVE5, BASE_NEXUS1, BASE_NEXUS2, BASE_NEXUS3, BASE_BUBPIPE, BASE_BUBPIPE_S, BASE_BUBPIPE_L, BASE_BUBPIPE_T,
            BASE_BUBPIPE_X, S_SAIL0, S_SAIL1, S_SAIL2, S_SAIL3, BANNER_CHU, BANNER_BLOB, BANNER_POLO, BANNER_NADA, BANNER_HUB, BANNER_CHEF,
            BANNER_SPOOKY, BANNER_SLIMY, BANNER_AGT, BANNER_AMINO, BANNER_CAFE, BANNER_UFT, BANNER_QIT, ODD_EGG, MYSTERY_BEACON, SPEC_TITLE1,
            SPEC_TITLE2, SPEC_TITLE3, SPEC_TITLE4, SPEC_TITLE5, SPEC_TITLE6, SPEC_TITLE7, SPEC_TITLE8, SPEC_TITLE9, SPEC_TITLE10, SPEC_TITLE11,
            SPEC_TITLE12, SPEC_TITLE13, SPEC_TITLE14, SPEC_TITLE15, SPEC_TITLE16, SPEC_TITLE17, SPEC_TITLE18, SPEC_TITLE19, SPEC_TITLE20,
            SPEC_TITLE21, SPEC_TITLE22, SPEC_TITLE23, SPEC_TITLE24, SPEC_TITLE25, SPEC_TITLE26, SPEC_TITLE27, SPEC_TITLE28, SPEC_TITLE29,
            SPEC_TITLE30, TITLE_SPOOKY1, TITLE_SPOOKY2, SLIME_MED, SPOOKY_PLANT, SPEC_PETCUST1, SPEC_PETCUST2, SPEC_PETCUST3, SPEC_BB_TRACK01,
            SPEC_BB_TRACK02, SPEC_BB_TRACK03, S_POSTER12, S_POSTER14, S_POSTER16, U_LASER1, U_LASER2, U_LASER3, U_LASER4, U_LASERX, U_SCANNER1,
            U_SCANNER2, U_SCANNER3, U_SCANNER4, U_SCANNERX, U_BOLT1, U_BOLT2, U_BOLT3, U_BOLT4, U_BOLTX, U_GRENADE1, U_GRENADE2, U_GRENADE3,
            U_GRENADE4, U_GRENADEX, U_TGRENADE1, U_TGRENADE2, U_TGRENADE3, U_TGRENADE4, U_TGRENADEX, U_RAIL1, U_RAIL2, U_RAIL3, U_RAIL4,
            U_RAILX, U_SHOTGUN1, U_SHOTGUN2, U_SHOTGUN3, U_SHOTGUN4, U_SHOTGUNX, U_SMG1, U_SMG2, U_SMG3, U_SMG4, U_SMGX, U_ENERGY1, U_ENERGY2,
            U_ENERGY3, U_ENERGYX, U_HAZARDX, U_JETBOOST1, U_JETBOOST2, U_JETBOOST3, U_JETBOOST4, U_JETBOOSTX, U_SHIELDBOOST1, U_SHIELDBOOST2,
            U_SHIELDBOOST3, U_SHIELDBOOST4, U_SHIELDBOOSTX, U_UNW1, U_UNW2, U_UNW3, U_RAD1, U_RAD2, U_RAD3, U_TOX1, U_TOX2, U_TOX3, U_COLDPROT1,
            U_COLDPROT2, U_COLDPROT3, U_HOTPROT1, U_HOTPROT2, U_HOTPROT3, U_PULSE1, U_PULSE2, U_PULSE3, U_PULSE4, U_PULSEX, U_LAUNCH1, U_LAUNCH2,
            U_LAUNCH3, U_LAUNCH4, U_LAUNCHX, U_HYPER1, U_HYPER2, U_HYPER3, U_HYPER4, U_HYPERX, U_SHIPSHIELD1, U_SHIPSHIELD2, U_SHIPSHIELD3,
            U_SHIPSHIELD4, U_SHIPSHIELDX, U_SHIPGUN1, U_SHIPGUN2, U_SHIPGUN3, U_SHIPGUN4, U_SHIPGUNX, U_SHIPLAS1, U_SHIPLAS2, U_SHIPLAS3,
            U_SHIPLAS4, U_SHIPLASX, U_SHIPSHOT1, U_SHIPSHOT2, U_SHIPSHOT3, U_SHIPSHOT4, U_SHIPSHOTX, U_SHIPMINI1, U_SHIPMINI2, U_SHIPMINI3,
            U_SHIPMINI4, U_SHIPMINIX, U_SHIPBLOB1, U_SHIPBLOB2, U_SHIPBLOB3, U_SHIPBLOB4, U_SHIPBLOBX, U_EXOGUN1, U_EXOGUN2, U_EXOGUN3,
            U_EXOGUN4, U_EXOLAS1, U_EXOLAS2, U_EXOLAS3, U_EXOLAS4, U_EXOBOOST1, U_EXOBOOST2, U_EXOBOOST3, U_EXOBOOST4, U_EXO_ENG1, U_EXO_ENG2,
            U_EXO_ENG3, U_EXO_ENG4, U_EXO_SUB1, U_EXO_SUB2, U_EXO_SUB3, U_EXO_SUB4, U_EXO_SUBGUN1, U_EXO_SUBGUN2, U_EXO_SUBGUN3, U_EXO_SUBGUN4,
            U_MECH_ENG2, U_MECH_ENG3, U_MECH_ENG4, U_MECHLAS2, U_MECHLAS3, U_MECHLAS4, U_MECHGUN2, U_MECHGUN3, U_MECHGUN4, AP_PULSE1, AP_PULSE2,
            AP_PULSE3, AP_PULSE4, AP_LAUNCH1, AP_LAUNCH2, AP_LAUNCH3, AP_LAUNCH4, AP_HYPER1, AP_HYPER2, AP_HYPER3, AP_HYPER4, AP_SHIPSHIELD1,
            AP_SHIPSHIELD2, AP_SHIPSHIELD3, AP_SHIPSHIELD4, AP_SHIPGUN1, AP_SHIPGUN2, AP_SHIPGUN3, AP_SHIPGUN4, AP_SHIPLAS1, AP_SHIPLAS2,
            AP_SHIPLAS3, AP_SHIPLAS4, U_FR_HYP1, U_FR_HYP2, U_FR_HYP3, U_FR_HYP4, U_FR_SPE1, U_FR_SPE2, U_FR_SPE3, U_FR_SPE4, U_FR_FUEL1,
            U_FR_FUEL2, U_FR_FUEL3, U_FR_FUEL4, U_FR_COM1, U_FR_COM2, U_FR_COM3, U_FR_COM4, U_FR_TRA1, U_FR_TRA2, U_FR_TRA3, U_FR_TRA4,
            U_FR_EXP1, U_FR_EXP2, U_FR_EXP3, U_FR_EXP4, U_FR_MINE1, U_FR_MINE2, U_FR_MINE3, U_FR_MINE4, BAIT_BASIC, BAIT_MEAT_1, BAIT_MEAT_2,
            BAIT_MEAT_3, BAIT_MEAT_4, BAIT_VEG_1, BAIT_VEG_2, BAIT_VEG_3, BAIT_VEG_4, FOOD_V_BLOB, FOOD_V_GEK, FOOD_V_DIPLO, FOOD_V_REX,
            FOOD_V_CAT, FOOD_V_STRIDER, FOOD_V_COW, FOOD_V_CRAB, FOOD_V_BONE, FOOD_V_MOLE, FOOD_V_ROBOT, FOOD_V_FLYER, FOOD_V_EGG, FOOD_V_MILK,
            FOOD_M_FISH, FOOD_M_FLYER, FOOD_M_FIEND, FOOD_M_BLOB, FOOD_M_GEK, FOOD_M_DIPLO, FOOD_M_REX, FOOD_M_CAT, FOOD_M_STRIDER, FOOD_M_COW,
            FOOD_M_CRAB, FOOD_M_MOLE, FOOD_M_BONE, FOOD_M_DRILL, FOOD_M_BEETLE, FOOD_M_BALL, FOOD_M_DIGGER, FOOD_M_MEAT, FOOD_P_LUSHWILD,
            FOOD_P_LUSHFARM, FOOD_P_HOTWILD, FOOD_P_HOTFARM, FOOD_P_COLDWILD, FOOD_P_COLDFARM, FOOD_P_TOXWILD, FOOD_P_TOXFARM, FOOD_P_RADWILD,
            FOOD_P_RADFARM, FOOD_P_DUSTWILD, FOOD_P_DUSTFARM, FOOD_P_GLITCH, FOOD_P_ALL1, FOOD_P_ALL2, FOOD_P_ALL3, FOOD_P_CAVE, FOOD_P_WATER,
            FOOD_P_POOP, FOOD_P_DEATH, FOOD_P_STELLAR, FOOD_R_EGGS, FOOD_R_FLOUR, FOOD_R_SUGAR, FOOD_R_HONEY, FOOD_R_VEG, FOOD_R_MEAT, FOOD_R_SMOKED,
            FOOD_R_BUTTER, FOOD_R_GBUTTER, FOOD_R_CREAM, FOOD_R_GCREAM, FOOD_R_CARAMEL, FOOD_R_OIL, FOOD_R_GOIL, FOOD_R_PASTRY, FOOD_R_BREAD,
            FOOD_R_BONEMILK, FOOD_R_BBUTTER, FOOD_R_BCHEESE, FOOD_R_BCUSTARD, FOOD_R_BCREAM, FOOD_R_CUSTARD, FOOD_R_FCUSTARD, FOOD_R_MCUSTARD,
            FOOD_R_SCUSTARD, FOOD_R_MERINGUE, FOOD_R_DONUT, FOOD_R_GONUT, FOOD_R_CHOC, FOOD_R_SWEETBUT, FOOD_R_SWEETGEK, FOOD_R_HONEYBUT,
            FOOD_R_HONEYGEK, FOOD_R_BLOBGEK, FOOD_R_BLOBBUT, FOOD_R_CHEESE, FOOD_R_GCHEESE, FOOD_R_DOUGH, FOOD_JAM_GLITCH, FOOD_JAM_HOT,
            FOOD_JAM_RAD, FOOD_JAM_DUST, FOOD_JAM_CAT, FOOD_JAM_CRAB, FOOD_DNUT_CUST, FOOD_DNUT_FCUST, FOOD_DNUT_MCUST, FOOD_DNUT_SCUST,
            FOOD_DNUT_HON, FOOD_DNUT_HONB, FOOD_DNUT_BLOB, FOOD_DNUT_CARM, FOOD_DNUT_CHOC, FOOD_DNUT_MEAT, FOOD_DNUT_JAM, FOOD_DNUT_CJAM,
            FOOD_DNUT_AJAM, FOOD_R_PIECASE, FOOD_PIE_MEAT, FOOD_PIE_SMEAT, FOOD_PIE_VEG, FOOD_PIE_FISH, FOOD_PIE_FIEND, FOOD_PIE_ORGAN,
            FOOD_PIE_GEK, FOOD_PIE_CRAB, FOOD_PIE_BERRY, FOOD_PIE_GLOW, FOOD_PIE_MUSH, FOOD_PIE_JAM, FOOD_PIE_WEIRD, FOOD_PIE_CACTUS, FOOD_PIE_HONEY,
            FOOD_PIE_ROOTS, FOOD_PIE_GREASE, FOOD_PIE_CAT, FOOD_PIE_CRABJ, FOOD_PIE_CHOC, FOOD_PIE_CARM, FOOD_PIE_CREAM, FOOD_PIE_CUST,
            FOOD_PIE_MCUST, FOOD_PIE_SCUST, FOOD_PIE_CHEESE, FOOD_PIE_VCHEE, FOOD_PIE_BONE, FOOD_PIE_DRILL, FOOD_PIE_BEET, FOOD_PIE_DIG,
            FOOD_PIE_BALL, FOOD_PIE_MOLE, FOOD_MEAT_STEW, FOOD_VEG_STEW, FOOD_ORGAN_STEW, FOOD_STEW_BONE, FOOD_STEW_DRILL, FOOD_STEW_BEET,
            FOOD_STEW_DIG, FOOD_STEW_BALL, FOOD_EGGPIE, FOOD_EGGPIE_M, FOOD_EGGPIE_G, FOOD_EGGPIE_GM, FOOD_EGGPIE_B, FOOD_EGGPIE_MU, FOOD_J_ALL3,
            FOOD_J_LUSH, FOOD_J_HOT, FOOD_J_DUST, FOOD_J_SALT, FOOD_S_VEG, FOOD_S_HOT, FOOD_S_CREAM, FOOD_S_CHEESE, FOOD_STEW_O_CH, FOOD_STEW_V_CH,
            FOOD_STEW_M_CH, FOOD_STEW_O_CR, FOOD_STEW_V_CR, FOOD_STEW_M_CR, FOOD_STEW_O_HOT, FOOD_STEW_V_HOT, FOOD_STEW_M_HOT, FOOD_STEW_O_VEG,
            FOOD_STEW_V_VEG, FOOD_STEW_M_VEG, FOOD_R_CAKEMIX, FOOD_R_GCAKEMIX, FOOD_R_BCAKEMIX, FOOD_R_MCAKEMIX, FOOD_R_MERMIX, FOOD_R_MMERMIX,
            FOOD_CK_HONEY, FOOD_CK_CREAM, FOOD_CK_BLOBBUT, FOOD_CK_CHOC, FOOD_CK_CARM, FOOD_CK_APPLE, FOOD_CK_CACTUS, FOOD_CK_JAM, FOOD_CK_JHOT,
            FOOD_CK_JGLITCH, FOOD_CK_CUST, FOOD_CK_FCUST, FOOD_CK_MCUST, FOOD_CK_SCUST, FOOD_R_EYEBALLS, FOOD_R_EYESTEW, FOOD_R_EYEICE,
            FOOD_ICE, FOOD_ICE_FISH, FOOD_ICE_FIEND, FOOD_ICE_STAR, FOOD_ICE_CHOC, FOOD_ICE_CARM, FOOD_ICE_FRUIT, FOOD_ICE_APPLE, FOOD_ICE_HONEY,
            FOOD_ICE_GLITCH, FOOD_ICE_GRAH, FOOD_ICE_BONE, FOOD_ICE_HOT, FOOD_CG_BLOB, FOOD_CG_CREAM, FOOD_CG_CHOC, FOOD_CG_CARM, FOOD_CG_APPLE,
            FOOD_CG_CACTUS, FOOD_CG_JAM, FOOD_CG_JHOT, FOOD_CG_JGLITCH, FOOD_CG_CUST, FOOD_CG_FCUST, FOOD_CG_SCUST, FOOD_CB_HONEY, FOOD_CB_CREAM,
            FOOD_CB_CHOC, FOOD_CB_CARM, FOOD_CB_APPLE, FOOD_CB_CACTUS, FOOD_CB_JAM, FOOD_CB_JHOT, FOOD_CB_JGLITCH, FOOD_CB_CUST, FOOD_CB_FCUST,
            FOOD_CB_SCUST, FOOD_CM_CREAM, FOOD_CM_CHOC, FOOD_CM_CARM, FOOD_CM_APPLE, FOOD_CM_CACTUS, FOOD_CM_JAM, FOOD_CM_JHOT, FOOD_CM_JGLITCH,
            FOOD_MC_HONEY, FOOD_MC_BLOB, FOOD_MC_CREAM, FOOD_MC_CHOC, FOOD_MC_CARM, FOOD_MC_APPLE, FOOD_MC_CACTUS, FOOD_MC_JAM, FOOD_MC_JHOT,
            FOOD_MC_JGLITCH, FOOD_MC_CUST, FOOD_MM_HONEY, FOOD_MM_BLOB, FOOD_MM_CREAM, FOOD_MM_CHOC, FOOD_MM_CARM, FOOD_MM_APPLE, FOOD_MM_CACTUS,
            FOOD_MM_JAM, FOOD_MM_JHOT, FOOD_MM_JGLITCH, FOOD_MM_CUST, FOOD_CM_BLOBBUT, FOOD_CM_HONEY, FOOD_CG_HONEY
        }
        /* 0x0 */ public gcproducttableEnumEnum gcproducttableEnum;
    }
}