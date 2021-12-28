// Must be included solely by a user

#pragma once

#ifdef _WIN32 // Windows-only
// Memory
#include ".\Memory\Memory.hpp"
#include ".\Memory\External.hpp"
#include ".\Memory\Internal.hpp"

// Other
#include ".\Memory\Address.hpp"
#include ".\Memory\Helper.hpp"
#endif
