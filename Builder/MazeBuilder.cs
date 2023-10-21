﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryForLabyrinth;
namespace Builder
{
    internal class MazeBuilder
    {
        private readonly Maze _maze = new();
        public void BuildRoom(int roomNumber)
        {
            if (roomNumber < 0)
            {
                throw new ArgumentException("Номер комнаты должен быть неотрицательным.");
            }
            Room room = new(roomNumber);

            room.SetSide(Direction.North, new Wall());
            room.SetSide(Direction.South, new Wall());
            room.SetSide(Direction.West, new Wall());
            room.SetSide(Direction.East, new Wall());

            _maze.AddRoom(room);
        }
        public void DoorBuilder(int roomNumber1, int roomNumber2)
        {
            if (roomNumber1 < 0)
            {
                throw new ArgumentException("Номер комнаты должен быть неотрицательным.");
            }
            if (roomNumber2 < 0)
            {
                throw new ArgumentException("Номер комнаты должен быть неотрицательным.");
            }
            Room? room1 = _maze.NumberCheck(roomNumber1);
            Room? room2 = _maze.NumberCheck(roomNumber2);
            if (room1 == null)
            {
                throw new ArgumentException("Комнаты с указанным номером не существуют.");
            }
            if (room2 == null)
            {
                throw new ArgumentException("Комнаты с указанным номером не существуют.");
            }
            Door door = new(room1, room2, true);
            room1.SetSide(Direction.East, door);
            room2.SetSide(Direction.West, door);
        }
        public virtual Maze GetMaze()
        {
            return _maze;
        }
    }
}
