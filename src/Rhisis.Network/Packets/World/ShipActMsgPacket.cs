﻿using Rhisis.Game.Abstractions.Protocol;
using LiteNetwork.Protocol.Abstractions;

namespace Rhisis.Network.Packets.World
{
    public class ShipActMsgPacket : IPacketDeserializer
    {
        /// <summary>
        /// Gets the message.
        /// </summary>
        public uint Message { get; private set; }

        /// <summary>
        /// Gets the first parameter.
        /// </summary>
        public int Parameter1 { get; private set; }

        /// <summary>
        /// Gets the second parameter.
        /// </summary>
        public int Parameter2 { get; private set; }

        /// <summary>
        /// Gets the ship.
        /// </summary>
        public uint Ship { get; private set; }

        /// <inheritdoc />
        public void Deserialize(ILitePacketStream packet)
        {
            Message = packet.Read<uint>();
            Parameter1 = packet.Read<int>();
            Parameter2 = packet.Read<int>();
            Ship = packet.Read<uint>();
        }
    }
}