
#include "../../NMSProxy//libMBIN/directories.hpp"

inline namespace CreateMbin
{
	namespace Globals
	{
		void WaterGlobals()
		{
			auto mbin{ (libMBIN::NMS::Globals::GcWaterGlobals^)libMBIN::FileIO::LoadMbin(L"..\\Binaries\\NMSDebugger\\templates\\GCWATERGLOBALS.GLOBAL.MBIN") };
			// -------------------------------------------------------------------

			mbin->WaveHeight = 0.1f;

			// -------------------------------------------------------------------
			mbin->WriteToMbin(L"..\\Binaries\\NMSDebugger\\output\\GCWATERGLOBALS.GLOBAL.MBIN");
		}
	}
}
void createMbin()
{
	CreateMbin::Globals::WaterGlobals();
}
