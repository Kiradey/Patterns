﻿using LibraryForLabyrinth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Builder
{
    internal class ClapedMazeBuilder : MazeBuilder
    {
        protected override Room CreateRoom(int roomNumber)
        {
            return new RoomWithClap(roomNumber);
        }
    }
}
