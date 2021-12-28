// =============================================================
#include <Windows.h>
#include <iostream>
#include <stdlib.h>

#include "..\..\CasualLibrary\CasualLibrary.hpp"
#include "..\..\Mem\MemUtils\memex.hpp"
#include "..\..\Mem\MemUtils\constants.hpp"
#include "..\..\Mem\MemHack\mainhack.hpp"
#include "..\..\libMBIN\directories.hpp"
#include "..\..\Mem\MemHack\globals.hpp"
#include "..\..\Mem\MemHack\initialize.hpp"
#include "../MemUtils/memop.hpp"

#pragma comment (lib, "user32.lib")
// =============================================================

// ---- Global Scope ----

using std::string;

// =============================================================

namespace MainHack
{
	void exampleHack()
	{
		// Dereference Multi-level pointer
		{
			uintptr_t baseAddr_DaySky{ constants::moduleBase + 0x037AE758 }; // "NMS.exe + 0x037AE758" as seen in cheat engine
			uintptr_t offsets_baseAddr_DaySky[] = { 0x100, 0x110 }; // Pointer Offsets

			// Dereference Multilevel Pointer to get address | In this case this is a 2 level pointer 
			uintptr_t firstAddr_Day{ FindDMAAddy((baseAddr_DaySky), { offsets_baseAddr_DaySky }, sizeof(offsets_baseAddr_DaySky) / sizeof(offsets_baseAddr_DaySky[0])) }; // SkyColour.R | Index 0

			auto bytes{ 4 };
			auto SkyColour_R = firstAddr_Day;
			auto SkyColour_G = SkyColour_R + bytes;
			auto SkyColour_B = SkyColour_G + bytes;
			auto SkyColour_A = SkyColour_B + bytes;

			// if Address is found... do stuff
			if (!(firstAddr_Day == NULL))
			{
				// Read From Memory
				{
					// if Numpad0 is pressed, read from memory and print values to console
					if (GetAsyncKeyState(VK_NUMPAD0))
					{
						static bool init{ false };
						if (!init)
						{
							std::cout << "==========================================" << std::endl;
							std::cout << "SkyColour Addresses: " << std::endl;
							std::cout << "SkyColour_R = " << SkyColour_R << std::endl;
							std::cout << "SkyColour_G = " << SkyColour_G << std::endl;
							std::cout << "SkyColour_B = " << SkyColour_B << std::endl;
							std::cout << "SkyColour_A = " << SkyColour_A << std::endl;

							std::cout << "                                            " << std::endl;

							std::cout << "SkyColour: {";
							std::cout << "R = " << Memory::Internal::read<float>(SkyColour_R) << ", ";
							std::cout << "G = " << Memory::Internal::read<float>(SkyColour_G) << ", ";
							std::cout << "B = " << Memory::Internal::read<float>(SkyColour_B) << ", ";
							std::cout << "A = " << Memory::Internal::read<float>(SkyColour_A);
							std::cout << "}" << std::endl;

							Sleep(100); // To prevent spammy prints
						}
					}
				}

				// Write To Memory
				{
					// if Numpad1 is pressed, write to memory
					if (GetAsyncKeyState(VK_NUMPAD1))
					{
						*(float*)(SkyColour_R) = 1.f;
						*(float*)(SkyColour_G) = 1.f;
						*(float*)(SkyColour_B) = 1.f;
						*(float*)(SkyColour_A) = 1.f;
					}
				}
			}
		}
	}
	void do_memory_operation()
	{
		exampleHack();

		NMSProxy::Globals::do_stuff(); // Global Mbin hacks
		Initialize::SigScan::scanner(); // Sig Scan operations
	}

	// -------------------------------------------------------------------

	DWORD WINAPI main(LPVOID param) // our main thread
	{
		createDependencies();
		Initialize::initializeAddresses(); // Initialize Address + Offsets

		while (true)
		{
			do_memory_operation();

			Sleep(100); // To reduce CPU taxation
		}
		return TRUE;
	}
}