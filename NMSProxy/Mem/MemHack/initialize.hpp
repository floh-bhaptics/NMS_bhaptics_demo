// =============================================================
#ifndef INITIALIZE_HPP
#define INITIALIZE_HPP

#include <iostream>
#include "../MemUtils/memex.hpp"
#include  "../MemUtils/constants.hpp"
using std::string;

// =============================================================
namespace Initialize
{
	namespace SigScan
	{
		// Sig Scan Types
		namespace SigType
		{
			enum class type
			{
				GcPlanetData,
				GcWeatherProperties,
			};
		}

		namespace Sigs
		{
			struct Sigs
			{
				 char* patternTest{ "" };
				const char* GcWeatherProperties{ "7C 20 57 65 61 74 68 65 72 20 7C" };
				const char* GcPlanetData{ "53 43 45 4E 45 53 2F 44 45 4D 4F 53 2F 4D 41 52 43 48 31 39 56 52 2F 50 6C 61 6E 65 74 73 2F 50 6C 61 6E 65 74 ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00" };
				const char* DisableModWarning{ "C6 80 92 26 00 00 ??" };

				const char* global_base_instruction_addr{ "74 0A F3 0F 10 3D ?? ?? ?? ?? EB 08 F3 0F 10 3D ?? ?? ?? ?? 48 8B CB" };
				const char* check_SeaLevel1{ "c7 41 ? ? ? ? ? 33 ed 89 69" };
				const char* check_SeaLevel2{ "89 69 ? 48 8b d9 90" };
				const char* check_SeaLevel3{ "f3 0f 11 82 ? ? ? ? c3 cc" };
				const char* check_BeachHeight{ "c7 41 ?? ?? ?? ?? ?? 33 ed ??" };
				const char* check_NoSeaBaseLevel{ "48 c7 41 ?? ?? ?? ?? ?? 89 69 ?? 48 89 6c 24" };
				const char* check_MinimumCaveDepth{ "c7 83 ?? ?? ?? ?? ?? ?? ?? ?? c7 83 ?? ?? ?? ?? ?? ?? ?? ?? c7 83 ?? ?? ?? ?? ?? ?? ?? ?? c7 83 ?? ?? ?? ?? ?? ?? ?? ?? c7 83 ?? ?? ?? ?? ?? ?? ?? ?? c7 83 ?? ?? ?? ?? ?? ?? ?? ?? c7 83 ?? ?? ?? ?? ?? ?? ?? ?? 48 8b 5c 24 ?? 48 83 c4 ?? 5f c3 cc cc cc cc cc cc cc cc 41 56" };
				const char* check_CaveRoofSmoothingDist{ "c7 83 ?? ?? ?? ?? ?? ?? ?? ?? c7 83 ?? ?? ?? ?? ?? ?? ?? ?? c7 83 ?? ?? ?? ?? ?? ?? ?? ?? c7 83 ?? ?? ?? ?? ?? ?? ?? ?? c7 83 ?? ?? ?? ?? ?? ?? ?? ?? c7 83 ?? ?? ?? ?? ?? ?? ?? ?? 48 8b 5c 24 ?? 48 83 c4 ?? 5f c3 cc cc cc cc cc cc cc cc 41 56" };
				const char* check_MaximumSeaLevelCaveDepth{ "c7 83 ?? ?? ?? ?? ?? ?? ?? ?? c7 83 ?? ?? ?? ?? ?? ?? ?? ?? c7 83 ?? ?? ?? ?? ?? ?? ?? ?? c7 83 ?? ?? ?? ?? ?? ?? ?? ?? c7 83 ?? ?? ?? ?? ?? ?? ?? ?? 48 8b 5c 24 ?? 48 83 c4 ?? 5f c3 cc cc cc cc cc cc cc cc 41 56" };
				const char* check_BuildingTextureRadius{ "c7 83 ?? ?? ?? ?? ?? ?? ?? ?? c7 83 ?? ?? ?? ?? ?? ?? ?? ?? c7 83 ?? ?? ?? ?? ?? ?? ?? ?? c7 83 ?? ?? ?? ?? ?? ?? ?? ?? 48 8b 5c 24 ?? 48 83 c4 ?? 5f c3 cc cc cc cc cc cc cc cc 41 56" };
				const char* check_BuildingSmoothingRadius{ "c7 83 ?? ?? ?? ?? ?? ?? ?? ?? c7 83 ?? ?? ?? ?? ?? ?? ?? ?? c7 83 ?? ?? ?? ?? ?? ?? ?? ?? 48 8b 5c 24 ?? 48 83 c4 ?? 5f c3 cc cc cc cc cc cc cc cc 41 56" };
				const char* check_BuildingSmoothingHeight{ "c7 83 ?? ?? ?? ?? ?? ?? ?? ?? c7 83 ?? ?? ?? ?? ?? ?? ?? ?? 48 8b 5c 24 ?? 48 83 c4 ?? 5f c3 cc cc cc cc cc cc cc cc 41 56" };
				const char* check_WaterFadeInDistance{ "c7 83 ?? ?? ?? ?? ?? ?? ?? ?? 48 8b 5c 24 ?? 48 83 c4 ?? 5f c3 cc cc cc cc cc cc cc cc 41 56" };
			};

			inline Sigs sigs;
		}
		struct Scan
		{
			bool scan_GcWeatherProperties;
			bool scan_testOptions;
			bool scan_planets;
		};
		inline Scan scan;

		void scanner();
		void sigScan(cmk::Memex pattern, SigScan::SigType::type type);
	}
	namespace Addresses
	{
		namespace BaseTypes
		{
			struct GcSeed
			{
				uintptr_t Seed;
				uintptr_t UseSeedValue;
			};

			struct Colour
			{
				uintptr_t R;
				uintptr_t G;
				uintptr_t B;
				uintptr_t A;
			};
			struct Vector2f
			{
				uintptr_t x;
				uintptr_t y;
			};
			struct Vector3f
			{
				uintptr_t x;
				uintptr_t y;
				uintptr_t z;
			};
			struct Vector4f
			{
				uintptr_t x;
				uintptr_t y;
				uintptr_t z;
				uintptr_t t; // t is w in NMS.exe
			};
		}
		namespace Toolkit
		{
			struct TkPaletteTexture
			{
				uintptr_t Palette;
				uintptr_t ColourAlt;
			};
			struct TkNoiseUberData
			{
				uintptr_t Octaves;
				uintptr_t SlopeGain;
				uintptr_t SlopeBias;
				uintptr_t SharpToRoundFeatures;
				uintptr_t AmplifyFeatures;
				uintptr_t PerturbFeatures;
				uintptr_t AltitudeErosion;
				uintptr_t RidgeErosion;
				uintptr_t SlopeErosion;
				uintptr_t Lacunarity;
				uintptr_t Gain;
				uintptr_t RemapFromMin;
				uintptr_t RemapFromMax;
				uintptr_t RemapToMin;
				uintptr_t RemapToMax;
				uintptr_t DebugNoiseType;
			};
			struct TkNoiseUberLayerData
			{
				TkNoiseUberData NoiseData;
				uintptr_t  Active;
				uintptr_t   MaximumLOD;
				uintptr_t  Subtract{ };
				uintptr_t   NoiseVoxelType;
				uintptr_t Height;
				uintptr_t Width;
				uintptr_t RegionRatio;
				uintptr_t RegionScale;
				uintptr_t RegionGain;
				uintptr_t SmoothRadius;
				uintptr_t HeightOffset;
				uintptr_t   OffsetType;
				uintptr_t   WaterFade;
				uintptr_t PlateauStratas;
				uintptr_t   PlateauSharpness;
				uintptr_t PlateauRegionSize;
				uintptr_t   SeedOffset;
				uintptr_t TileBlendMeters;
			};
			struct TkNoiseSuperFormulaData
			{
				uintptr_t Form_m;
				uintptr_t Form_n1;
				uintptr_t Form_n2;
				uintptr_t Form_n3;
			};
			struct TkNoiseSuperPrimitiveData
			{
				uintptr_t Width;
				uintptr_t Height;
				uintptr_t Depth;
				uintptr_t Thickness;
				uintptr_t CornerRadiusXY;
				uintptr_t CornerRadiusZ;
				uintptr_t BottomRadiusOffset;
			};
			struct TkNoiseGridData
			{
				uintptr_t  Active;
				uintptr_t   MaximumLOD;
				uintptr_t  Subtract{ };
				uintptr_t   NoiseVoxelType;
				uintptr_t   NoiseGridType;
				uintptr_t MinWidth;
				uintptr_t MaxWidth;
				uintptr_t MinHeight;
				uintptr_t MaxHeight;
				uintptr_t MinHeightOffset;
				uintptr_t MaxHeightOffset;
				uintptr_t HeightOffset;
				uintptr_t OffsetType;
				uintptr_t RegionRatio;
				uintptr_t RegionScale;

				TkNoiseUberLayerData TurbulenceNoiseLayer;

				uintptr_t Yaw;
				uintptr_t Pitch;
				uintptr_t Roll;
				uintptr_t VaryYaw;
				uintptr_t   VaryPitch;
				uintptr_t   VaryRoll;
				uintptr_t SmoothRadius;
				uintptr_t   SeedOffset;
				uintptr_t RandomPrimitive;

				TkNoiseSuperFormulaData SuperFormula1;
				TkNoiseSuperFormulaData SuperFormula2;
				TkNoiseSuperPrimitiveData SuperPrimitive;

				uintptr_t TileBlendMeters;
			};
			struct TkNoiseFeatureData
			{
				uintptr_t Active;
				uintptr_t MaximumLOD;
				uintptr_t Subtract;
				uintptr_t NoiseVoxelType;
				uintptr_t FeatureType;
				uintptr_t Width;
				uintptr_t Height;
				uintptr_t Octaves;
				uintptr_t RegionSize;
				uintptr_t Ratio;
				uintptr_t HeightVarianceAmplitude;
				uintptr_t HeightVarianceFrequency;
				uintptr_t HeightOffset;
				uintptr_t OffsetType;
				uintptr_t SmoothRadius;
				uintptr_t SeedOffset;
				uintptr_t TileBlendMeters;
			};
			struct TkNoiseCaveData
			{
				TkNoiseFeatureData Mouth;
				TkNoiseFeatureData Tunnel;
			};
			struct TkVoxelGeneratorData
			{
				BaseTypes::GcSeed GcSeed;
				uintptr_t SeaLevel;
				uintptr_t BeachHeight;
				uintptr_t NoSeaBaseLevel;
				uintptr_t BuildingVoxelType;
				uintptr_t ResourceVoxelType;

				uintptr_t MinimumCaveDepth;
				uintptr_t CaveRoofSmoothingDist;
				uintptr_t MaximumSeaLevelCaveDepth;
				uintptr_t BuildingTextureRadius;
				uintptr_t BuildingSmoothingRadius;
				uintptr_t BuildingSmoothingHeight;
				uintptr_t WaterFadeInDistance;
				TkNoiseUberLayerData NoiseLayers[8];
				TkNoiseGridData GridLayers[9];
				TkNoiseFeatureData Features[7];
				TkNoiseCaveData Caves;
			};
		}
		namespace GameComponents
		{
			enum class RainbowTypeEnum
			{
				Always, Occasional, Storm, None
			};
			struct GcColourModifier
			{
				uintptr_t ForceColour;
				BaseTypes::Colour ForceColourTo;
				uintptr_t OffsetSaturation;
				uintptr_t OffsetValue;
				uintptr_t MultiplySaturation;
				uintptr_t MultiplyValue;
			};
			struct GcWeatherColourModifiers
			{
				GcColourModifier SkyColour;
				GcColourModifier SkyUpperColour;
				GcColourModifier HorizonColour;
				GcColourModifier SunColour;
				GcColourModifier FogColour;
				GcColourModifier HeightFogColour;
				GcColourModifier LightColour;
				GcColourModifier CloudColour1;
				GcColourModifier CloudColour2;
				GcColourModifier HeavyAirColour[5];
			};
			struct GcHeavyAirSettingValues
			{
				uintptr_t Thickness;
				uintptr_t Speed;
				uintptr_t Alpha1;
				uintptr_t Alpha2;
				Toolkit::TkPaletteTexture Colour1;
				Toolkit::TkPaletteTexture Colour2;
			};
			struct GcHeavyAirSetting
			{
				GcHeavyAirSettingValues Settings[5];
			};
			struct GcFogProperties
			{
				uintptr_t FogStrength;
				uintptr_t FogMax;
				uintptr_t FogColourStrength;
				uintptr_t FogColourMax;
				uintptr_t HeightFogStrength;
				uintptr_t HeightFogFadeOutStrength;
				uintptr_t HeightFogOffset;
				uintptr_t HeightFogMax;
				uintptr_t FogHeight;
				GcHeavyAirSetting HeavyAir;
				uintptr_t CloudRatio;
				uintptr_t FullscreenEffect;
				uintptr_t DepthOfField;
				uintptr_t DepthOfFieldDistance;
				uintptr_t DepthOfFieldFade;
				uintptr_t IsRaining;
				uintptr_t RainWetness;
			};
			struct GcHazardValues
			{
				uintptr_t Normal;
				uintptr_t Extreme;
			};
			enum class GcHazardValueTypesEnum
			{
				Ambient, Water, Cave, Storm, Night
			};

			enum class HazardModifierEnum
			{
				Temperature, Toxicity, Radiation, LifeSupportDrain, Gravity
			};
			struct GcHazardModifiers
			{
				GcHazardValues HazardValues;
			};
			struct GcStormProperties
			{
				uintptr_t Weighting;
				GcFogProperties Fog;
				GcWeatherColourModifiers ColourModifiers;
				GcHazardValues HazardModifiers[5];
			};
			enum class ScreenFilterEnum {
				Default, DefaultStorm, Frozen, FrozenStorm, Toxic, ToxicStorm, Radioactive, RadioactiveStorm, Scorched, ScorchedStorm,
				Barren, BarrenStorm, Weird1, Weird2, Weird3, Weird4, Weird5, Weird6, Weird7, Weird8,
				Vintage, HyperReal, Desaturated, Amber, GBGreen, Apocalypse, Diffusion, Green, BlackAndWhite, Isolation,
				Sepia, Filmic, GBGrey, Binoculars, Surveying, Nexus, SpaceStation, Freighter, FreighterAbandoned, Frigate,
				MissionSurvey, NewVibrant, NewVibrantBright, NewVibrantWarm, NewVintageBright, NewVintageWash, Drama, MemoryBold, Memory, MemoryWash,
				Autumn, AutumnFade, ClassicBright, Classic, ClassicWash, BlackAndWhiteDream, ColourTouchB, ColourTouchC, NegativePrint, SepiaExtreme,
				Solarise, TwoToneStrong, TwoTone, Dramatic, Fuchsia, Violet, Cyan, GreenNew, AmberNew, Red,
				HueShiftA, HueShiftB, HueShiftC, HueShiftD, WarmStripe, NMSRetroA, NMSRetroB, NMSRetroC, NMSRetroD, NMSRetroE,
				NMSRetroF, NMSRetroG
			};
			struct GcScreenFilters
			{
				uintptr_t ScreenFilter;
			};
			struct GcSkyProperties
			{
				uintptr_t AtmosphereThickness;
				uintptr_t HorizonMultiplier;
				uintptr_t DuskHorizonMultiplier;
				uintptr_t NightHorizonMultiplier;
				uintptr_t HorizonFadeSpeed;
				uintptr_t DayHorizonTightness;
				uintptr_t SunSize;
				uintptr_t SunStrength;
				uintptr_t SunSurroundSize;
				uintptr_t SunSurroundStrength;
				uintptr_t UpperSkyFadeSpeed;
				uintptr_t UpperSkyFadeOffset;
			};
			struct GcLightShaftProperties
			{
				uintptr_t LightShaftScattering;
				uintptr_t LightShaftStrength;
				uintptr_t LightShaftBottom;
				uintptr_t LightShaftTop;
				BaseTypes::Colour LightShaftColourBottom;
				BaseTypes::Colour LightShaftColourTop;
			};
			struct GcWeatherProperties
			{
				string Name;
				uintptr_t UseWeatherFog;
				GcFogProperties Fog;
				GcFogProperties FlightFog;
				GcFogProperties StormFog;
				GcFogProperties ExtremeFog;
				GcWeatherColourModifiers ExtremeColourModifiers;
				uintptr_t RainbowChance[4];
				GcStormProperties Storms[1000];
				uintptr_t HeavyAir[1000];
				uintptr_t LowStormsChance;
				uintptr_t HighStormsChance;
				uintptr_t ExtremeWeatherChance;
				uintptr_t OverrideTemperature;
				GcHazardValues Temperature[5];
				uintptr_t OverrideToxicity;
				GcHazardValues Toxicity[5];
				uintptr_t OverrideRadiation;
				GcHazardValues Radiation[5];
				GcHazardValues LifeSupportDrain[5];
				GcScreenFilters StormFilterOptions[1000];
				uintptr_t UseWeatherSky;
				GcSkyProperties	Sky;
				uintptr_t UseLightShaftProperties;
				GcLightShaftProperties LightShaftProperties;
				uintptr_t UseStormLightShaftProperties;
				GcLightShaftProperties StormLightShaftProperties;
				string WeatherEffectsIds[1000];
				string WeatherHazardsIds[1000];
			};
			inline GcWeatherProperties WeatherProperties;
			enum class PaletteEnum
			{
				Grass, Plant, Leaf, Wood, Rock, Stone, Crystal, Sand, Dirt, Metal,
				Paint, Plastic, Fur, Scale, Feather, Water, Cloud, Sky, Space, Underbelly,
				Undercoat, Snow, SkyHorizon, SkyFog, SkyHeightFog, SkySunset, SkyNight, WaterNear, SpaceCloud, SpaceBottom,
				SpaceSolar, SpaceLight, Warrior, Scientific, Trader, WarriorAlt, ScientificAlt, TraderAlt, RockSaturated, RockLight,
				RockDark, PlanetRing, Custom_Head, Custom_Torso, Custom_Chest_Armour, Custom_Backpack, Custom_Arms, Custom_Hands, Custom_Legs, Custom_Feet,
				Cave, GrassAlt, BioShip_Body, BioShip_Underbelly, BioShip_Cockpit
			};
			struct PaletteType
			{
				uintptr_t Grass[4];
				uintptr_t Plant[4];
				uintptr_t Leaf[4];
				uintptr_t Wood[4];
				uintptr_t Rock[4];
				uintptr_t Stone[4];
				uintptr_t Crystal[4];
				uintptr_t Sand[4];
				uintptr_t Dirt[4];
				uintptr_t Metal[4];
				uintptr_t Paint[4];
				uintptr_t Plastic[4];
				uintptr_t Fur[4];
				uintptr_t Scale[4];
				uintptr_t Feather[4];
				uintptr_t Water[4];
				uintptr_t Cloud[4];
				uintptr_t Sky[4];
				uintptr_t Space[4];
				uintptr_t Underbelly[4];
				uintptr_t Undercoat[4];
				uintptr_t Snow[4];
				uintptr_t SkyHorizon[4];
				uintptr_t SkyFog[4];
				uintptr_t SkyHeightFog[4];
				uintptr_t SkySunset[4];
				uintptr_t SkyNight[4];
				uintptr_t WaterNear[4];
				uintptr_t SpaceCloud[4];
				uintptr_t SpaceBottom[4];
				uintptr_t SpaceSolar[4];
				uintptr_t SpaceLight[4];
				uintptr_t Warrior[4];
				uintptr_t Scientific[4];
				uintptr_t Trader[4];
				uintptr_t WarriorAlt[4];
				uintptr_t ScientificAlt[4];
				uintptr_t TraderAlt[4];
				uintptr_t RockSaturated[4];
				uintptr_t RockLight[4];
				uintptr_t RockDark[4];
				uintptr_t PlanetRing[4];
				uintptr_t Custom_Head[4];
				uintptr_t Custom_Torso[4];
				uintptr_t Custom_Chest_Armour[4];
				uintptr_t Custom_Backpack[4];
				uintptr_t Custom_Arms[4];
				uintptr_t Custom_Hands[4];
				uintptr_t Custom_Legs[4];
				uintptr_t Custom_Feet[4];
				uintptr_t Cave[4];
				uintptr_t GrassAlt[4];
				uintptr_t BioShip_Body[4];
				uintptr_t BioShip_Underbelly[4];
				uintptr_t BioShip_Cockpit[4];
			};

			struct GcPaletteData
			{
				uintptr_t NumColours;
				BaseTypes::Colour Colours[64];
			};
			struct GcPaletteList
			{
				GcPaletteData Palettes[55];
			};

			struct GcPlanetWaterColourData
			{
				BaseTypes::Colour WaterFogColourNear;
				BaseTypes::Colour WaterFogColourFar;
				BaseTypes::Colour WaterColourBase;
				BaseTypes::Colour WaterColourAdd;
				BaseTypes::Colour FoamColour;
			};
			struct GcHeavyAirColourData
			{
				BaseTypes::Colour Colour1;
				BaseTypes::Colour Colour2;
			};
			struct GcPlanetHeavyAirData
			{
				std::string Filename;
				GcHeavyAirColourData Colours;
			};
			struct GcPlanetWaterData
			{
				uintptr_t ColourIndex;
				uintptr_t WaterStrength;
				uintptr_t WaterColourStrength;
				uintptr_t WaterMultiplyStrength;
				uintptr_t WaterMultiplyMax;
				uintptr_t WaterRoughness;
				uintptr_t FresnelPower;
				uintptr_t FresnelMin;
				uintptr_t FresnelMax;
				uintptr_t Wave1Scale;
				uintptr_t Wave1Height;
				uintptr_t Wave1Speed;
				uintptr_t Wave2Scale;
				uintptr_t Wave2Height;
				uintptr_t Wave2Speed;
				uintptr_t NormalMap1Scale;
				uintptr_t NormalMap1Speed;
				uintptr_t NormalMap2Scale;
				uintptr_t NormalMap2Speed;
				uintptr_t FoamFadeHeight;
				uintptr_t Foam1Scale;
				uintptr_t Foam1Speed;
				uintptr_t Foam2Scale;
				uintptr_t Foam2Speed;
				GcPlanetHeavyAirData HeavyAir;
			};
			struct GcWaterColourSettingList
			{
				GcPlanetWaterColourData Settings[16];
			};

			struct GcSolarSystemSkyColourData
			{
				BaseTypes::Colour TopColour;
				BaseTypes::Colour MidColour;
				BaseTypes::Colour BottomColour;
				BaseTypes::Colour TopColourPlanet;
				BaseTypes::Colour MidColourPlanet;
				BaseTypes::Colour BottomColourPlanet;
				BaseTypes::Colour CloudColour;
				BaseTypes::Colour LightColour;
				BaseTypes::Colour NebulaColour1;
				BaseTypes::Colour NebulaColour2;
				BaseTypes::Colour NebulaColour3;
				BaseTypes::Colour FogColour;
				BaseTypes::Colour FogColour2;
			};
			struct GcSpaceSkyColourSettingList
			{
				GcSolarSystemSkyColourData Settings[16];
			};

			enum class BiomeEnum
			{
				Lush, Toxic, Scorched, Radioactive, Frozen, Barren, Dead, Weird, Red, Green, Blue, Test, Swamp, Lava, Waterworld, All
			};
			struct GcPlanetWeatherColourData
			{
				BaseTypes::Colour SkyColour;
				BaseTypes::Colour SkyUpperColour;
				BaseTypes::Colour SkySolarColour;
				BaseTypes::Colour HorizonColour;
				BaseTypes::Colour SunColour;
				BaseTypes::Colour FogColour;
				BaseTypes::Colour HeightFogColour;
				BaseTypes::Vector3f SkyGradientSpeed;
				BaseTypes::Colour LightColour;
				BaseTypes::Colour CloudColour1;
				BaseTypes::Colour CloudColour2;
			};
			struct GcWeatherColourSettingList
			{
				GcPlanetWeatherColourData PlanetWeatherColourData[1000];
			};
			struct GcWeatherColourSettings
			{
				GcWeatherColourSettingList GenericSettings;
				GcWeatherColourSettingList PerBiomeSettings[16];
			};
			inline GcWeatherColourSettings WeatherColourSettings;
		}
		namespace Globals
		{
			struct BaseAddr_Globals
			{
				uintptr_t addr{ Memory::Internal::findSignature(constants::moduleBase, Initialize::SigScan::Sigs::sigs.global_base_instruction_addr) + 0x18F9237 }; // 
			};
			inline BaseAddr_Globals baseAddr_Globals;

			struct GcWaterGlobals
			{
				uintptr_t RenderReflections;
				uintptr_t WaveHeight;
				uintptr_t WaveFrequency;
				uintptr_t WaveChoppiness;
				uintptr_t WaveCutoff;
				uintptr_t Epsilon;
				uintptr_t FresnelPow;
				uintptr_t FresnelMul;
				uintptr_t FresnelAlpha;
				uintptr_t FresnelBelowPow;
				uintptr_t FresnelBelowMul;
				uintptr_t FresnelBelowAlpha;
				BaseTypes::Colour WaterHeavyAirColour;
				GameComponents::GcPlanetWaterData WaterDataDay;
				GameComponents::GcPlanetWaterColourData WaterColourNight;
			};
			inline GcWaterGlobals WaterGlobals;

			struct GcSkyGlobals
			{
				uintptr_t RainbowDistance;
				uintptr_t DayLength;
				uintptr_t SafeSkyMinIndex;
				uintptr_t SafeSkyMaxIndex;
				uintptr_t FrozenSkyMinIndex;
				uintptr_t FrozenSkyMaxIndex;
			};
			inline GcSkyGlobals SkyGlobals;
		}
		namespace Custom
		{
			struct GcPlanetData
			{
				// Current Planet
				uintptr_t planet[100];

				// Checks
				uintptr_t check_SeaLevel1;
				uintptr_t check_SeaLevel2;
				uintptr_t check_SeaLevel3;
				uintptr_t check_BeachHeight;
				uintptr_t check_NoSeaBaseLevel;
				uintptr_t check_MinimumCaveDepth;
				uintptr_t check_CaveRoofSmoothingDist;
				uintptr_t check_MaximumSeaLevelCaveDepth;
				uintptr_t check_BuildingTextureRadius;
				uintptr_t check_BuildingSmoothingRadius;
				uintptr_t check_BuildingSmoothingHeight;
				uintptr_t check_WaterFadeInDistance;
			};
			inline GcPlanetData PlanetData;
		}
	}

	void initializeAddresses();
}
namespace NMSProxy
{
	namespace Globals
	{
		void do_stuff();
	}
}
#endif
