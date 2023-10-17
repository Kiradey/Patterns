using System;
namespace LibraryForLabyrinth
{
    public class Room : IMapSite
    {
        public int roomNumber { get; private set; }
        protected IMapSite[] SideInit { get; private set; }
        public Room(int roomNumber)
        {
            if (roomNumber < 0)
            {
                throw new ArgumentException("Неверный номер комнаты.");
            }
            this.roomNumber = roomNumber;
            SideInit = new IMapSite[4];
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
    }
}