//===================================================================
#ifndef  MEMEX_HPP
#define MEMEX_HPP

//===================================================================
//
//  Memex - like Regex, but for scanning memory.
// 
//  Parse "## ?? #?" format string.
//  # - hex  nibble
//  ? - mask nibble
// 
//  test = (value & mask) == (pattern & mask)
//  e.g. "12 ?? 34 ?6 7?" gives
//  pattern {12, 00, 34, 06, 70 }
//  mask    {ff, 00, ff, 0f, f0 }
//
//===================================================================

#include <stdlib.h>
#include <memory>
#include <string>
#include <vector>
#include <windows.h>
#include <psapi.h>

//===================================================================
namespace cmk {
	//===================================================================

	class  Memex
	{
	protected:
		// skip mem pages with any of these Protect states
		static constexpr  DWORD  s_invalid_page_protect{
			PAGE_NOACCESS | PAGE_TARGETS_INVALID | PAGE_GUARD
		};

	protected:
		std::string  m_string{};
		std::byte* m_pattern{ nullptr };
		std::byte* m_mask{ nullptr };
		uint64_t     m_length{ 0 };
		HANDLE       m_process{ nullptr };
		bool         m_process_is_current{ true };

		std::byte  hex_to_byte(char HEX)       const;
		bool  is_match(const std::byte* ADDR)  const;

	public:
		// PROCESS must have permission to read memory.
		Memex(const std::string& PATTERN, HANDLE PROCESS = ::GetCurrentProcess());
		~Memex(void);

		const HANDLE        Process(void)  const;
		const std::string& String(void)  const;
		const std::byte* Pattern(void)  const;
		const std::byte* Mask(void)  const;
		uint64_t            Length(void)  const;

		// Check if Length bytes starting at (current process) ADDR match Patern and Mask.
		bool  IsMatch(const void* ADDR)  const;

		/// <summary>
		/// Scan all loaded Process modules.
		/// Will find this Pattern in execute (image) memory, not static or alloc memory.
		/// </summary>
		std::vector<const std::byte*>  Matches(void)  const;

		/// <summary>
		/// Scan Process MODULE for this Pattern & Mask.
		/// MatchResult in Process memory.
		/// Will find this Pattern in execute (image) memory, not static or alloc memory.
		/// </summary>
		const std::byte* Match(HMODULE MODULE, uint64_t INSTANCE = 1)  const;
		std::vector<const std::byte*>  Matches(HMODULE MODULE)                         const;

		/// <summary>
		/// Scan all accessable committed memory pages in Process for this Pattern.
		/// TYPE is mask for MEMORY_BASIC_INFORMATION.Type:
		/// One or more of:
		/// MEM_IMAGE   - module image (exe code)
		/// MEM_MAPPED  - mem mapped file(s)
		/// MEM_PRIVATE - not visible to other processes e.g. statics, alloc'd mem
		/// https://docs.microsoft.com/en-us/windows/win32/api/winnt/ns-winnt-memory_basic_information
		/// </summary>
		const std::byte* Match(DWORD TYPE, uint64_t INSTANCE = 1)  const;
		std::vector<const std::byte*>  Matches(DWORD TYPE)                         const;
	};

	//===================================================================
}
//===================================================================

#include "..\MemUtils\memex.cpi"

//===================================================================

#endif // ! MEMEX_HPP
