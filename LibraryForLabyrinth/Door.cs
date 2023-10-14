using System;
namespace LibraryForLabyrinth
{
    public class Door : IMapSite
    {
        private readonly Room _room1;
        private readonly Room _room2;
        private readonly bool _isOpen;
        public Door(Room room1, Room room2, bool isOpen)
        {
            if (room1 == null || room2 == null)
            {
                throw new ArgumentNullException("Комнаты не могут быть пустыми.");
            }
            _room1 = room1;
            _room2 = room2;
            _isOpen = isOpen;
        }
        public Room OtherSideFrom(Room site)
        {
            if (site.RoomNumber == _room1.RoomNumber)
            {
                return _room2;
            }
            else if (site.RoomNumber == _room2.RoomNumber)
            {
                return _room1;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        public virtual void Enter()
        {
            if (_isOpen)
            {
                Console.WriteLine("Вы прошли через дверь.");
            }
            else
            {
                Console.WriteLine("Дверь закрыта, вы не можете пройти.");
            }
        }
    }
}