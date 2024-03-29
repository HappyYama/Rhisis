﻿using System;

namespace Rhisis.Game.Common;

[Flags]
public enum StateMode : int
{
    NONE = 0,
    PK_MODE = 0x00000001,
    PVP_MODE = 0x00000002,
    BASEMOTION_MODE = 0x00000004,
    BASEMOTION = 0x0000000c,
}

public enum StateModeBaseMotion : byte
{
    BASEMOTION_ON = 0x00,
    BASEMOTION_OFF = 0x01,
    BASEMOTION_CANCEL = 0x02,
}
