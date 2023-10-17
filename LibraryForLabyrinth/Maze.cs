using System;
using System.Collections.Generic;
namespace LibraryForLabyrinth
{
    public class Maze
    {
        private List<Room> _roomList = new List<Room>();
        public void AddRoom(Room room)
        {
            if (room == null)
            {
                throw new ArgumentNullException("Комната не может быть пустой.");
            }
            _roomList.Add(room);
        }
        public Room? NumberCheck(int Number)
        {
            if (Number < 0)
            {
                throw new ArgumentOutOfRangeException("Номер комнаты не может быть отрицательным.");
            }
            return _roomList.SingleOrDefault(room => room.roomNumber == Number);
        }
    }
}