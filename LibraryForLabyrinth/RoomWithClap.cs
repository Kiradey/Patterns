using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryForLabyrinth
{
    public class RoomWithClap : Room
    {
        private readonly DoorWithClap? _clapDoor;
        public RoomWithClap(int roomNumber, List<IMapSite> sideInit) : base(roomNumber)
        {
            if (sideInit == null)
            {
                throw new ArgumentNullException("Список сторон не может быть пустым.");
            }

            _clapDoor = sideInit.OfType<DoorWithClap>().FirstOrDefault();
        }
        public override void Enter()
        {
            base.Enter();
            Console.WriteLine("Хлопок! Вы встретили хлопушку!");
            if (_clapDoor != null)
            {
                _clapDoor.Enter();
            }
        }
    }

}
