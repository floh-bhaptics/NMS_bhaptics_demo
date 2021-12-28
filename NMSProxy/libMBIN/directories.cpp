// =============================================================
#include <iostream>
#include <fstream>
#include <direct.h>
// =============================================================

void create_txt_about()
{
    const char* path_about{ "..\\Binaries\\NMSProxy\\NMSProxyTemplate.txt" };
    std::ofstream file_about(path_about);
    file_about << "NMSProxy is an internal hack, which allows for real-time manipulation of No Man's Sky, additional functionality to No Man's Sky & a wide variety of other features. \n";
    file_about << "Where to contact me | Discord: RaYRoD TV#7679 | Visit https://discord.gg/hPxEcdU for news, updates, and discussion. \n";
    file_about << "Check here for updates: https://www.nexusmods.com/nomanssky/mods/2118 \n";
    file_about.close();
}
void create_directories()
{
    _mkdir("..\\Binaries\\NMSProxy\\");
    _mkdir("..\\Binaries\\NMSProxy\\output\\");
    _mkdir("..\\Binaries\\NMSProxy\\output\\CUSTOMPALETTES");
    _mkdir("..\\Binaries\\NMSProxy\\output\\METADATA");
    _mkdir("..\\Binaries\\NMSProxy\\output\\METADATA\\SIMULATION");
    _mkdir("..\\Binaries\\NMSProxy\\output\\METADATA\\SIMULATION\\SOLARSYSTEM");
    _mkdir("..\\Binaries\\NMSProxy\\output\\METADATA\\SIMULATION\\SOLARSYSTEM\\WEATHER");
    _mkdir("..\\Binaries\\NMSProxy\\output\\METADATA\\SIMULATION\\SOLARSYSTEM\\WEATHER\\SKYSETTINGS");
}
void create_directories_templates()
{
    _mkdir("..\\Binaries\\NMSProxy\\templates\\");
    _mkdir("..\\Binaries\\NMSProxy\\templates\\METADATA");
    _mkdir("..\\Binaries\\NMSProxy\\templates\\METADATA\\SIMULATION");
    _mkdir("..\\Binaries\\NMSProxy\\templates\\METADATA\\SIMULATION\\SOLARSYSTEM");
    _mkdir("..\\Binaries\\NMSProxy\\templates\\METADATA\\SIMULATION\\SOLARSYSTEM\\WEATHER");
    _mkdir("..\\Binaries\\NMSProxy\\templates\\METADATA\\SIMULATION\\SOLARSYSTEM\\WEATHER\\SKYSETTINGS");
}
void createDependencies()
{
    create_txt_about();

    // ==============================

    // Mbin Directories for libMbin
   /* create_directories_templates();
    create_directories();*/
}

// =============================================================