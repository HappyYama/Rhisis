﻿using Rhisis.Game.Common;
using Rhisis.Protocol;

namespace Rhisis.Game.Protocol.Packets.World.Client;

public class MagicAttackPacket
{
    /// <summary>
    /// Gets the attack message.
    /// </summary>
    public ObjectMessageType AttackMessage { get; private set; }

    /// <summary>
    /// Gets the target object id.
    /// </summary>
    public uint TargetObjectId { get; private set; }

    /// <summary>
    /// Gets the second parameter.
    /// </summary>
    public int Parameter2 { get; private set; }

    /// <summary>
    /// Gets the third parameter.
    /// </summary>
    public int Parameter3 { get; private set; }

    /// <summary>
    /// Gets the magic power.
    /// </summary>
    public int MagicPower { get; private set; }

    /// <summary>
    /// Gets the SFX projectile id.
    /// </summary>
    public int ProjectileId { get; private set; }

    public MagicAttackPacket(FFPacket packet)
    {
        AttackMessage = (ObjectMessageType)packet.ReadUInt32();
        TargetObjectId = packet.ReadUInt32();
        Parameter2 = packet.ReadInt32();
        Parameter3 = packet.ReadInt32();
        MagicPower = packet.ReadInt32();
        ProjectileId = packet.ReadInt32();
    }
}
