﻿using Rhisis.Protocol;

namespace Rhisis.Game.Protocol.Packets.World.Client;

public class DropItemPacket
{
    /// <summary>
    /// Gets the item type
    /// </summary>
    public uint ItemType { get; private set; }

    /// <summary>
    /// Gets the item index in the inventory.
    /// </summary>
    public int ItemIndex { get; private set; }

    /// <summary>
    /// Gets the item quantity.
    /// </summary>
    public int ItemQuantity { get; private set; }

    /// <summary>
    /// Gets the position.
    /// </summary>
    public Vector3 Position { get; private set; }

    public DropItemPacket(FFPacket packet)
    {
        ItemType = packet.ReadUInt32();
        ItemIndex = packet.ReadInt32();
        ItemQuantity = packet.ReadInt16();
        Position = new Vector3(packet.ReadSingle(), packet.ReadSingle(), packet.ReadSingle());
    }
}