//===================================================================

#include ".\memex.hpp"
#include <iostream>

//===================================================================
namespace cmk {
	//===================================================================


	Memex::Memex(const std::string& PATTERN, HANDLE PROCESS)
		: m_string{ PATTERN }
		, m_process{ PROCESS }
	{
		m_process_is_current = m_process == ::GetCurrentProcess();

		// "## ?? #?" missing last space, otherwise parse 3 char at a time,
		// first two are hex or ?, followed by a space.
		m_length = (m_string.length() + 1) / 3;
		m_pattern = (std::byte*)::malloc(m_length);
		m_mask = (std::byte*)::malloc(m_length);

		for (uint64_t i{ 0 }, j{ 0 }; j < m_length; ++j, ++i) {
			auto  char0 = m_string[i++];
			auto  char1 = m_string[i++];
			auto  pattern0 = hex_to_byte(char0);
			auto  pattern1 = hex_to_byte(char1);
			auto  mask0 = (std::byte)(char0 == '?' ? 0 : 0xf);
			auto  mask1 = (std::byte)(char1 == '?' ? 0 : 0xf);
			m_pattern[j] = (pattern0 << 4) | pattern1;
			m_mask[j] = (mask0 << 4) | mask1;
		}
	}

	//-------------------------------------------------------------------

	Memex::~Memex(void)
	{
		m_length = 0;
		if (m_mask)  ::free(m_mask);
		if (m_pattern)  ::free(m_pattern);
	}

	//-------------------------------------------------------------------

	bool  Memex::IsMatch(const void* ADDR)  const
	{
		return is_match((const std::byte*)ADDR);
	}

	//-------------------------------------------------------------------

	std::vector<const std::byte*>  Memex::Matches(void)  const
	{
		std::vector<const std::byte*>  matches{};

		DWORD  size{ 0 };
		if (!::EnumProcessModulesEx(m_process, nullptr, 0, &size, LIST_MODULES_DEFAULT))  return matches;

		auto  length{ size / sizeof(HMODULE) };
		auto  modules{ std::make_unique<HMODULE[]>(size) };
		size = length * sizeof(HMODULE);

		if (!::EnumProcessModulesEx(m_process, modules.get(), size, &size, LIST_MODULES_DEFAULT))  return matches;

		for (uint64_t i{ 0 }; i < length; ++i) {
			auto  module_hnd{ modules.get()[i] };
			auto  module_matches{ Matches(module_hnd) };
			for (uint64_t j(0); j < module_matches.size(); ++j) {
				matches.push_back(module_matches[j]);
			}

		}

		return matches;
	}

	//-------------------------------------------------------------------

	const std::byte* Memex::Match(HMODULE MODULE, uint64_t INSTANCE)  const
	{
		if (INSTANCE < 1)  return nullptr;

		MODULEINFO  mi{};
		::GetModuleInformation(m_process, MODULE, &mi, sizeof(mi));

		auto  base{ (const std::byte*)mi.lpBaseOfDll };
		auto  size{ mi.SizeOfImage };
		std::unique_ptr<std::byte[]>  local{};
		auto  addr{ base };

		if (m_process_is_current) base = 0;  // don't need to rebase
		else {
			local = std::make_unique<std::byte[]>(size);
			addr = local.get();

			// copy mem from other process into current process so we can scan
			SIZE_T  read_size{ 0 };
			::ReadProcessMemory(m_process, base, local.get(), size, &read_size);
			if (read_size != size)  return nullptr;
		}

		for (auto end{ addr + size - m_length }; addr < end; ++addr) {
			if (is_match(addr) && addr != m_pattern && !--INSTANCE) {
				return addr - local.get() + base;  // rebase from m_process to current process
			}
		}

		return nullptr;
	}

	//-------------------------------------------------------------------

	std::vector<const std::byte*>  Memex::Matches(HMODULE MODULE)  const
	{
		std::vector<const std::byte*>  matches{};

		MODULEINFO  mi{};
		::GetModuleInformation(m_process, MODULE, &mi, sizeof(mi));

		auto  base{ (const std::byte*)mi.lpBaseOfDll };
		auto  size{ mi.SizeOfImage };
		std::unique_ptr<std::byte[]>  local{};
		auto  addr{ base };

		if (m_process_is_current) base = 0;
		else {
			local = std::make_unique<std::byte[]>(size);
			addr = local.get();

			SIZE_T  read_size{ 0 };
			::ReadProcessMemory(m_process, base, local.get(), size, &read_size);
			if (read_size != size)  return matches;
		}

		for (auto end{ addr + size - m_length }; addr < end; ++addr) {
			if (is_match(addr) && addr != m_pattern) {
				matches.push_back(addr - local.get() + base);
			}
		}

		return matches;
	}

	//-------------------------------------------------------------------

	const std::byte* Memex::Match(DWORD TYPE, uint64_t INSTANCE)  const
	{
		if (INSTANCE < 1) return {};

		MEMORY_BASIC_INFORMATION  mbi{};

		std::byte* block{ nullptr };
		SIZE_T  size{ 0 };
		std::byte* local{ nullptr };

		for (; ::VirtualQueryEx(m_process, block, &mbi, sizeof(mbi)) > 0; block += size) {
			block = (std::byte*)mbi.BaseAddress;
			size = mbi.RegionSize;
			if (block >= (const std::byte*)0x0000800000000000) break;

			if ((mbi.State != MEM_COMMIT) ||
				(mbi.Protect == 0) ||
				(mbi.Protect & s_invalid_page_protect) != 0 ||
				(mbi.Type & TYPE) == 0
			)	 continue;

			DWORD  old_protect{ 0 };
			if (!::VirtualProtectEx(m_process, block, size, PAGE_EXECUTE_READWRITE, &old_protect)) {
				continue;
			}

			auto  base{ block };
			auto  addr{ base };
			auto  match{ (const std::byte*)nullptr };

			if (m_process_is_current) base = 0;
			else {
				local = (std::byte*)::realloc(local, size);
				addr = local;

				SIZE_T  read_size{ 0 };
				::ReadProcessMemory(m_process, base, local, size, &read_size);
				if (read_size != size) continue;
			}

			for (auto end{ addr + size - m_length }; addr < end; ++addr) {
				if (is_match(addr) && addr != m_pattern && !--INSTANCE) {
					match = base ? addr - local + base : addr;
					break;
				}
			}

			::VirtualProtectEx(m_process, block, size, old_protect, &old_protect);
			if (match) return match;
		}

		if (local) ::free(local);

		return {};
	}

	//-------------------------------------------------------------------

	std::vector<const std::byte*>  Memex::Matches(DWORD TYPE)  const
	{
		std::vector<const std::byte*>  matches{};

		MEMORY_BASIC_INFORMATION  mbi{};

		std::byte* block{ nullptr };
		SIZE_T  size{ 0 };
		std::byte* local{ nullptr };

		for (; ::VirtualQueryEx(m_process, block, &mbi, sizeof(mbi)); block += size) {
			block = (std::byte*)mbi.BaseAddress;
			size = mbi.RegionSize;
			if (block >= (const std::byte*)0x0000800000000000) break;

			if ((mbi.State != MEM_COMMIT) ||
				(mbi.Protect == 0) ||
				(mbi.Protect & s_invalid_page_protect) != 0 ||
				(mbi.Type & TYPE) == 0
			)	 continue;

			DWORD  old_protect{ 0 };
			if (!::VirtualProtectEx(m_process, block, size, PAGE_EXECUTE_READWRITE, &old_protect)) {
				continue;
			}

			auto  base{ block };
			auto  addr{ base };

			if (m_process_is_current) base = 0;
			else {
				local = (std::byte*)::realloc(local, size);
				addr = local;

				SIZE_T  read_size{ 0 };
				::ReadProcessMemory(m_process, base, local, size, &read_size);
				if (read_size != size) continue;
			}

			for (auto end{ addr + size - m_length }; addr < end; ++addr) {
				if (is_match(addr) && addr != m_pattern) {
					matches.push_back(base ? addr - local + base : addr);
				}
			}

			::VirtualProtectEx(m_process, block, size, old_protect, &old_protect);
		}

		if (local) ::free(local);

		return matches;
	}

	//===================================================================
}
//===================================================================
