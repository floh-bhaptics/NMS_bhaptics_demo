// =============================================================
#include <cstdint>
#include <iostream>

#include "CasualLibrary.hpp"
#include "initialize.hpp"
#include "../MemUtils/constants.hpp"
// =============================================================

namespace NMSProxy
{
	namespace Globals
	{
		// ---- Global Scope ----

		using namespace	Initialize::Addresses::Custom;
		using namespace Initialize::Addresses::Globals;

		static bool init{ false };

		// -------------------------------------------------------------

		void do_stuff()
		{
			// SkyGlobals
			{
				// =============================================================
				if (!(baseAddr_Globals.addr) == NULL)
				{
					*(int*)(SkyGlobals.DayLength) = 5400; // Longer Days
				}
			}
		}
	}
}

