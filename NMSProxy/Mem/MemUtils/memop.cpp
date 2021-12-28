#include <cstdint>
#include <vector>
#include <Windows.h>
#include <iostream>
#include <stdlib.h>

uintptr_t FindDMAAddy(uintptr_t baseAddress, uintptr_t offsets[], int pointerLevel)
{
	uintptr_t ptr = *(uintptr_t*)(baseAddress);
	if (ptr == 0) return NULL;

	for (int i = 0; i < pointerLevel; i++)
	{
		if (i == pointerLevel - 1)
		{
			ptr = (uintptr_t)(ptr + offsets[i]);
			if (ptr == 0) return NULL;
			return ptr;
		}
		else
		{
			ptr = *(uintptr_t*)(ptr + offsets[i]);
			if (ptr == 0) return NULL;
		}
	}
	return ptr;
}

//To write offsets or to NOP an address, there are other ways of doing it
DWORD Old;
void writeAddressBytes(DWORD64 address, int offset, SIZE_T bytes)
{
	VirtualProtect((void*)address, bytes, PAGE_EXECUTE_READWRITE, &Old); //unprotecting memory region
	memset((void*)address, offset, bytes); //writing to memory
	VirtualProtect((void*)address, bytes, Old, NULL); // and enable memory protection again
}
