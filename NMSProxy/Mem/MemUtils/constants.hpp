// =============================================================
#ifndef CONSTANTS_HPP
#define CONSTANTS_HPP

#include <cstdint>
// =============================================================

inline namespace constants
{
	const uintptr_t moduleBase{ Memory::Internal::getModule("NMS.exe") };
}

// =============================================================
#endif
