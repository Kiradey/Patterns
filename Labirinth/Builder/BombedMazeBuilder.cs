﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryForLabyrinth;
namespace Builder
{
    internal class BombedMazeBuilder : MazeBuilder
    {
        protected override Room CreateRoom(int roomNumber)
        {
            if (roomNumber < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(roomNumber), "Комната с отрицательным значением. Kiradey");
            }
            return new RoomWithBomb(roomNumber);
        }

    }
}
