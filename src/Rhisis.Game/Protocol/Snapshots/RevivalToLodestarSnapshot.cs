﻿using Rhisis.Game.Abstractions.Entities;
using Rhisis.Network;

namespace Rhisis.Game.Protocol.Snapshots
{
    public class RevivalToLodestarSnapshot : FFSnapshot
    {
        public RevivalToLodestarSnapshot(IPlayer player)
            : base(SnapshotType.REVIVAL_TO_LODESTAR, player.Id)
        {
        }
    }
}
