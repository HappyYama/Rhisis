﻿using Rhisis.Game;
using Rhisis.Protocol;

namespace Rhisis.Game.Protocol.Packets.World.Client;

public class PlayerBehavior2Packet
{
    /// <summary>
    /// Gets the BeginPosition.
    /// </summary>
    public Vector3 BeginPosition { get; private set; }

    /// <summary>
    /// Gets the DestinationPosition.
    /// </summary>
    public Vector3 DestinationPosition { get; private set; }

    /// <summary>
    /// Gets the Angle.
    /// </summary>
    public float Angle { get; private set; }

    /// <summary>
    /// Gets the X angle.
    /// </summary>
    public float AngleX { get; private set; }

    /// <summary>
    /// Gets the power.
    /// </summary>
    public float AccPower { get; private set; }

    /// <summary>
    /// Gets the turn angle.
    /// </summary>
    public float TurnAngle { get; private set; }

    /// <summary>
    /// Gets the state.
    /// </summary>
    public uint State { get; private set; }

    /// <summary>
    /// Gets the state flag.
    /// </summary>
    public uint StateFlag { get; private set; }

    /// <summary>
    /// Gets the motion.
    /// </summary>
    public uint Motion { get; private set; }

    /// <summary>
    /// Gets the motion ex.
    /// </summary>
    public int MotionEx { get; private set; }

    /// <summary>
    /// Gets the loop.
    /// </summary>
    public int Loop { get; private set; }

    /// <summary>
    /// Gets the motion option.
    /// </summary>
    public uint MotionOption { get; private set; }

    /// <summary>
    /// Gets the tick count.
    /// </summary>
    public long TickCount { get; private set; }

    public PlayerBehavior2Packet(FFPacket packet)
    {
        BeginPosition = new Vector3(packet.ReadSingle(), packet.ReadSingle(), packet.ReadSingle());
        DestinationPosition = new Vector3(packet.ReadSingle(), packet.ReadSingle(), packet.ReadSingle());
        Angle = packet.ReadSingle();
        AngleX = packet.ReadSingle();
        AccPower = packet.ReadSingle();
        TurnAngle = packet.ReadSingle();
        State = packet.ReadUInt32();
        StateFlag = packet.ReadUInt32();
        Motion = packet.ReadUInt32();
        MotionEx = packet.ReadInt32();
        Loop = packet.ReadInt32();
        MotionOption = packet.ReadUInt32();
        TickCount = packet.ReadInt64();
    }
}