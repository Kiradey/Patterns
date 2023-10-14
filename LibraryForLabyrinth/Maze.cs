using System;
using System.Collections.Generic;
namespace LibraryForLabyrinth
{
    public class Maze
    {
        private List<Room> roomList = new List<Room>();
        public void AddRoom(Room room)
        {
            roomList.Add(room);
        }
        public Room? NumberCheck(int Number)
        {
            return roomList.SingleOrDefault(room => room.RoomNumber == Number);
        }
    }
}