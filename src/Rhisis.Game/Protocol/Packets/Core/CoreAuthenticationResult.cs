﻿namespace Rhisis.Game.Protocol.Packets.Core;

public enum CoreAuthenticationResult
{
    Success,
    WrongMasterPassword,
    ClusterExists,
    WorldChannelExists
}