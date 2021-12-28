using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x8, GUID = 0x5C9D583BCD8E9957, NameHash = 0x42109FD0D90982DB)]
    public class GcMissionConditionInteractionIndexChanged : NMSTemplate
    {
        public GcInteractionType InteractionType;
        public GcAlienRace Race;
    }
}
