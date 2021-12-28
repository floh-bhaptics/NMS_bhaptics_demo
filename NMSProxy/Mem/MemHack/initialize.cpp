// =============================================================
#include <cstdint>
#include <iostream>
#include <CasualLibrary.hpp>

#include "initialize.hpp"
#include "../MemUtils/constants.hpp"
#include "./mainhack.hpp"
// =============================================================

// This file is used only for initializing addresses & Signature Scanning
// Signature scanning is triggered by other files

namespace Initialize
{
	// =============================================================

	// ---- Global Scope ----

	using namespace Initialize::Addresses::Custom;
	using namespace Initialize::Addresses::Globals;
	using namespace Initialize::Addresses::GameComponents;
	using namespace Initialize::SigScan;

	// -------------------------------------------------------------

	namespace SigScan
	{
		void sigScan(cmk::Memex pattern, SigScan::SigType::type type)
		{
			std::cout << "Scanning for addresses... " << std::endl;

			auto matches{ pattern.Matches(MEM_PRIVATE) };
#if true

			for (size_t i{ 0 }; i < matches.size(); ++i) {

				std::cout << std::hex << uintptr_t(matches[i]) << std::endl; // print all matches to console

				switch (type)
				{
					// =============================================================
					using SigScan::SigType::type;
					// =============================================================

				case type::GcPlanetData:
					// if address(s) are found, assign to array var... otherwise print "error";
					if (!(uintptr_t(matches[i]) == NULL))
					{
						PlanetData.planet[i] = (uint64_t(matches[i]));
					}
					break;

				case type::GcWeatherProperties:
					// if address(s) are found, assign to array var... otherwise print "error";
					if (!(uintptr_t(matches[0]) == NULL))
					{
						WeatherProperties.Name = (uint64_t(matches[i]));
					}
					break;

				default:
					std::cout << "Finished" << std::endl;
					break;
#endif
				}
			}
		}
		void scanner()
		{
				// if scan_planets is true (set to true by the 'Find Planet Addresses' Button in imgui_gcplanetdata_terrain.cpp), then initiate sigscan
				if (Initialize::SigScan::scan.scan_planets)
				{
					auto sig = Initialize::Sigs::sigs.GcPlanetData;

					Initialize::SigScan::sigScan(cmk::Memex(sig), SigScan::SigType::type::GcPlanetData);
					Initialize::SigScan::scan.scan_planets = false;
				}

				if (Initialize::SigScan::scan.scan_GcWeatherProperties)
				{
					auto sig = Initialize::Sigs::sigs.GcWeatherProperties;

					Initialize::SigScan::sigScan(cmk::Memex(sig), SigScan::SigType::type::GcWeatherProperties);
					Initialize::SigScan::scan.scan_GcWeatherProperties = false;
				}
		}
	}

	void initializeAddresses()
	{
		// Globals
		{
			std::cout << "Base Global Addr: " << std::hex << baseAddr_Globals.addr << std::endl;

			// GcSkyGlobals
			{
				// =============================================================
				const int bytes{ 4 };
				static auto firstAddr{ baseAddr_Globals.addr - 0x41CB60 }; // First variable of memory region or file
				// =============================================================

				SkyGlobals.RainbowDistance = firstAddr;
				SkyGlobals.DayLength = SkyGlobals.RainbowDistance + 104;
				SkyGlobals.SafeSkyMinIndex = SkyGlobals.RainbowDistance + 128;
				SkyGlobals.SafeSkyMaxIndex = SkyGlobals.RainbowDistance + 132;
				SkyGlobals.FrozenSkyMinIndex = SkyGlobals.RainbowDistance + 136;
				SkyGlobals.FrozenSkyMaxIndex = SkyGlobals.RainbowDistance + 140;

				// Print Out Addresses
				static bool init{ false };
				if (!init)
				{
					std::cout << "======================================================" << std::endl;
					std::cout << "GcSkyGlobals - RainbowDistance Addr: " << std::hex << SkyGlobals.RainbowDistance << std::endl;
					std::cout << "GcSkyGlobals - DayLength Addr: " << std::hex << SkyGlobals.DayLength << std::endl;
					std::cout << "GcSkyGlobals - SafeSkyMinIndex Addr: " << std::hex << SkyGlobals.SafeSkyMinIndex << std::endl;
					std::cout << "GcSkyGlobals - SafeSkyMaxIndex Addr: " << std::hex << SkyGlobals.SafeSkyMaxIndex << std::endl;
					std::cout << "GcSkyGlobals - FrozenSkyMinIndex Addr: " << std::hex << SkyGlobals.FrozenSkyMinIndex << std::endl;
					std::cout << "GcSkyGlobals - FrozenSkyMaxIndex Addr: " << std::hex << SkyGlobals.FrozenSkyMaxIndex << std::endl;
					init = !init;
				}
			}

			// GcWaterGlobals
			{
				// =============================================================
				static const int bytes{ 4 };
				static auto firstAddr{ baseAddr_Globals.addr + 0x1740 };
				// =============================================================

				WaterGlobals.RenderReflections = firstAddr;
				WaterGlobals.WaveHeight = WaterGlobals.RenderReflections + bytes;
				WaterGlobals.WaveFrequency = WaterGlobals.WaveHeight + bytes;
				WaterGlobals.WaveChoppiness = WaterGlobals.WaveFrequency + bytes;
				WaterGlobals.WaveCutoff = WaterGlobals.WaveChoppiness + bytes;
				WaterGlobals.Epsilon = WaterGlobals.WaveCutoff + bytes;
				WaterGlobals.FresnelPow = WaterGlobals.Epsilon + bytes;
				WaterGlobals.FresnelMul = WaterGlobals.FresnelPow + bytes;
				WaterGlobals.FresnelAlpha = WaterGlobals.FresnelMul + bytes;
				WaterGlobals.FresnelBelowPow = WaterGlobals.FresnelAlpha + bytes;
				WaterGlobals.FresnelBelowMul = WaterGlobals.FresnelBelowPow + bytes;
				WaterGlobals.FresnelBelowAlpha = WaterGlobals.FresnelBelowMul + bytes;
				WaterGlobals.WaterHeavyAirColour.R = WaterGlobals.FresnelBelowAlpha + bytes;

				WaterGlobals.WaterHeavyAirColour.G = WaterGlobals.WaterHeavyAirColour.R + bytes;
				WaterGlobals.WaterHeavyAirColour.B = WaterGlobals.WaterHeavyAirColour.G + bytes;
				WaterGlobals.WaterHeavyAirColour.A = WaterGlobals.WaterHeavyAirColour.B + bytes;

				WaterGlobals.WaterDataDay.ColourIndex = WaterGlobals.WaterHeavyAirColour.A + bytes;
				WaterGlobals.WaterDataDay.WaterStrength = WaterGlobals.WaterDataDay.ColourIndex + bytes;
				WaterGlobals.WaterDataDay.WaterColourStrength = WaterGlobals.WaterDataDay.WaterStrength + bytes;
				WaterGlobals.WaterDataDay.WaterMultiplyStrength = WaterGlobals.WaterDataDay.WaterColourStrength + bytes;
				WaterGlobals.WaterDataDay.WaterMultiplyMax = WaterGlobals.WaterDataDay.WaterMultiplyStrength + bytes;
				WaterGlobals.WaterDataDay.WaterRoughness = WaterGlobals.WaterDataDay.WaterMultiplyMax + bytes;
				WaterGlobals.WaterDataDay.FresnelPower = WaterGlobals.WaterDataDay.WaterRoughness + bytes;
				WaterGlobals.WaterDataDay.FresnelMin = WaterGlobals.WaterDataDay.FresnelPower + bytes;
				WaterGlobals.WaterDataDay.FresnelMax = WaterGlobals.WaterDataDay.FresnelMin + bytes;
				WaterGlobals.WaterDataDay.Wave1Scale = WaterGlobals.WaterDataDay.FresnelMax + bytes;
				WaterGlobals.WaterDataDay.Wave1Height = WaterGlobals.WaterDataDay.Wave1Scale + bytes;
				WaterGlobals.WaterDataDay.Wave1Speed = WaterGlobals.WaterDataDay.Wave1Height + bytes;
				WaterGlobals.WaterDataDay.Wave2Scale = WaterGlobals.WaterDataDay.Wave1Speed + bytes;
				WaterGlobals.WaterDataDay.Wave2Height = WaterGlobals.WaterDataDay.Wave2Scale + bytes;
				WaterGlobals.WaterDataDay.Wave2Speed = WaterGlobals.WaterDataDay.Wave2Height + bytes;
				WaterGlobals.WaterDataDay.NormalMap1Scale = WaterGlobals.WaterDataDay.Wave2Speed + bytes;
				WaterGlobals.WaterDataDay.NormalMap1Speed = WaterGlobals.WaterDataDay.NormalMap1Scale + bytes;
				WaterGlobals.WaterDataDay.NormalMap2Scale = WaterGlobals.WaterDataDay.NormalMap1Speed + bytes;
				WaterGlobals.WaterDataDay.NormalMap2Speed = WaterGlobals.WaterDataDay.NormalMap2Scale + bytes;
				WaterGlobals.WaterDataDay.FoamFadeHeight = WaterGlobals.WaterDataDay.NormalMap2Speed + bytes;
				WaterGlobals.WaterDataDay.Foam1Scale = WaterGlobals.WaterDataDay.FoamFadeHeight + bytes;
				WaterGlobals.WaterDataDay.Foam1Speed = WaterGlobals.WaterDataDay.Foam1Scale + bytes;
				WaterGlobals.WaterDataDay.Foam2Scale = WaterGlobals.WaterDataDay.Foam1Speed + bytes;
				WaterGlobals.WaterDataDay.Foam2Speed = WaterGlobals.WaterDataDay.Foam2Scale + bytes;

				WaterGlobals.WaterColourNight.WaterFogColourNear.R = WaterGlobals.WaterDataDay.Foam2Speed + 292;
				WaterGlobals.WaterColourNight.WaterFogColourNear.G = WaterGlobals.WaterColourNight.WaterFogColourNear.R + bytes;
				WaterGlobals.WaterColourNight.WaterFogColourNear.B = WaterGlobals.WaterColourNight.WaterFogColourNear.G + bytes;
				WaterGlobals.WaterColourNight.WaterFogColourNear.A = WaterGlobals.WaterColourNight.WaterFogColourNear.B + bytes;

				WaterGlobals.WaterColourNight.WaterFogColourFar.R = WaterGlobals.WaterColourNight.WaterFogColourNear.A + bytes;
				WaterGlobals.WaterColourNight.WaterFogColourFar.G = WaterGlobals.WaterColourNight.WaterFogColourFar.R + bytes;
				WaterGlobals.WaterColourNight.WaterFogColourFar.B = WaterGlobals.WaterColourNight.WaterFogColourFar.G + bytes;
				WaterGlobals.WaterColourNight.WaterFogColourFar.A = WaterGlobals.WaterColourNight.WaterFogColourFar.B + bytes;

				WaterGlobals.WaterColourNight.WaterColourBase.R = WaterGlobals.WaterColourNight.WaterFogColourFar.A + bytes;
				WaterGlobals.WaterColourNight.WaterColourBase.G = WaterGlobals.WaterColourNight.WaterColourBase.R + bytes;
				WaterGlobals.WaterColourNight.WaterColourBase.B = WaterGlobals.WaterColourNight.WaterColourBase.G + bytes;
				WaterGlobals.WaterColourNight.WaterColourBase.A = WaterGlobals.WaterColourNight.WaterColourBase.B + bytes;

				WaterGlobals.WaterColourNight.WaterColourAdd.R = WaterGlobals.WaterColourNight.WaterColourBase.A + bytes;
				WaterGlobals.WaterColourNight.WaterColourAdd.G = WaterGlobals.WaterColourNight.WaterColourAdd.R + bytes;
				WaterGlobals.WaterColourNight.WaterColourAdd.B = WaterGlobals.WaterColourNight.WaterColourAdd.G + bytes;
				WaterGlobals.WaterColourNight.WaterColourAdd.A = WaterGlobals.WaterColourNight.WaterColourAdd.B + bytes;

				WaterGlobals.WaterColourNight.FoamColour.R = WaterGlobals.WaterColourNight.WaterColourAdd.A + bytes;
				WaterGlobals.WaterColourNight.FoamColour.G = WaterGlobals.WaterColourNight.FoamColour.R + bytes;
				WaterGlobals.WaterColourNight.FoamColour.B = WaterGlobals.WaterColourNight.FoamColour.G + bytes;
				WaterGlobals.WaterColourNight.FoamColour.A = WaterGlobals.WaterColourNight.FoamColour.B + bytes;

				// Print Out Addresses
				static bool init{ false };
				if (!init)
				{
					std::cout << "======================================================" << std::endl;
					std::cout << "GcWaterGlobals - RenderReflections Addr: " << std::hex << WaterGlobals.RenderReflections << std::endl;
					std::cout << "GcWaterGlobals - WaterDataDay.ColourIndex Addr: " << WaterGlobals.WaterDataDay.ColourIndex << std::endl;
					init = !init;
				}
			}
		}
	}

	// =============================================================
}
