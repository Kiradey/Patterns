using System;
namespace LibraryForLabyrinth
{
    public class Door : IMapSite
    {
        private Room _room1;
        private Room _room2;
        private readonly bool _isOpen;
        public Door(Room room1, Room room2, bool isOpen)
        {
            if (room1 == null)
            {
                throw new ArgumentNullException(nameof(room1), "Комната не может быть пустой!.");
            }
            if (room2 == null)
            {
                throw new ArgumentNullException(nameof(room2), "Комната не может быть пустой!");
            }
            _room1 = room1;
            _room2 = room2;
            _isOpen = isOpen;
        }
        public Room OtherSideFrom(Room site)
        {
            if (site == null)
            {
                throw new ArgumentNullException(nameof(site), "Пустое значение!");
            }
            if (site.roomNumber == _room1.roomNumber)
            {
                return _room2;
            }
            else if (site.roomNumber == _room2.roomNumber)
            {
                return _room1;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(site), site, "Неверный номер комнаты.");
            }
        }
        public Door() { }
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
        public Door Clone()
        {
            return new Door(_room1.Clone(), _room2.Clone(), true);
        }
        public void Initializing(Room room1, Room room2)
        {
            if (room1 == null)
            {
                throw new ArgumentNullException(nameof(room1), "Комнаты не существует.");
            }
            if (room2 == null)
            {
                throw new ArgumentNullException(nameof(room2), "Комнаты не существует.");
            }
            _room1 = room1;
            _room2 = room2;
        }
    }
}
