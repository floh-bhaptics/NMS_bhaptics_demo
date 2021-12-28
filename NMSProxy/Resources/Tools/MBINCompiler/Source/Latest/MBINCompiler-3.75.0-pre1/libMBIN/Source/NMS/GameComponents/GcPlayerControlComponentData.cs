using libMBIN.NMS.Toolkit;
using System.Collections.Generic;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0xB0, GUID = 0x525F11AD648FC820, NameHash = 0xE15445D2CE8FD16D)]
    public class GcPlayerControlComponentData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 InitialState;
        /* 0x10 */ public GcPlayerControlInput BaseInput;
        /* 0x48 */ public NMSString0x10 BaseCamera;
        /* 0x58 */ public List<GcPlayerControlState> States;
        /* 0x68 */ public TkBlackboardKey AimDir;
        /* 0x80 */ public TkBlackboardKey TorchDir;
        /* 0x98 */ public TkBlackboardKey CrosshairDir;
    }
}
