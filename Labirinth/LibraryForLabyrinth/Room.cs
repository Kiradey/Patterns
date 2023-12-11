using System;
namespace LibraryForLabyrinth
{
    public class Room : IMapSite
    {
        internal int roomNumber { get; private set; }
        protected IMapSite[] SideInit = new IMapSite[4];
        public Room(int roomNumber1)
        {
            if (roomNumber1 <= 0)
            {
                throw new ArgumentException(nameof(roomNumber), "Неверный номер комнаты.");
            }
            roomNumber = roomNumber1;
        }
        public virtual void Enter()
        {
            Console.WriteLine("Вы вошли в комнату " + roomNumber);
        }
        public IMapSite GetSide(Direction direction)
        {
            return SideInit[(int)direction];
        }
        public void SetSide(Direction direction, IMapSite site)
        {
            SideInit[(int)direction] = site;
        }
        public virtual Room Clone()
        {
            return new Room(roomNumber);
        }
        public void Initializing(int roomNumber1)
        {
            if (roomNumber1 < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(roomNumber1), "Комната с отрицательным номером.");
            }
            roomNumber = roomNumber1;
        }
    }
}