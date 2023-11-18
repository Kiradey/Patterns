using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryForLabyrinth
{
    public class RoomWithClap : Room
    {
        public RoomWithClap(int roomNumber) : base(roomNumber)
        {
        }
        public override void Enter()
        {
            base.Enter();
            Console.WriteLine("Хлопок! Вы встретили хлопушку!");
            SideInit.OfType<DoorWithClap>().ToList().ForEach(door=>door.Enter());
        }
        public override Room Clone()
        {
            return new RoomWithClap(roomNumber);
        }
    }

}
