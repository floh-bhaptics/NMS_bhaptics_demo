// =============================================================

#include <Windows.h>
#include <stdio.h>
#include "pch.h"

#include "dllmain.hpp"
#include <iostream>

using namespace System;

// =============================================================
BOOL APIENTRY DllMain(HMODULE hModule, DWORD fdwReason, LPVOID)
{
	switch (fdwReason)
	{
	case DLL_PROCESS_ATTACH:
	{
		AllocConsole(); // enables the console
		freopen("CONIN$", "r", stdin); // Enable std::cin
		freopen("CONOUT$", "w", stdout); // Enable std::cout

		// NMSProxy | Custom Thread
		// =============================================================

		// Create new Thread for .dll hack
		CreateThread(0, 0, MainHack::main, hModule, 0, 0);

		// =============================================================
	}
	break;

	case DLL_PROCESS_DETACH:
		break;
	}

	return TRUE;
}