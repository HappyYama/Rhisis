﻿namespace Rhisis.Game.Common;

public enum AuthorityType : byte
{
    Banned = 0,
    Player = (byte)'F',
    GameMaster = (byte)'L',
    Administrator = (byte)'P'
}
