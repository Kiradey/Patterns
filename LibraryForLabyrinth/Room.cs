using System;
namespace LibraryForLabyrinth
{
    public class Room : IMapSite
    {
        public int RoomNumber { get; private set; }
        protected IMapSite[] SideInit { get; private set; }
        public Room(int _roomNumber)        {
            if (RoomNumber <= 0)
            {
                throw new ArgumentNullException("Неверный номер комнаты.");
            }
            this.RoomNumber = RoomNumber;
            SideInit = new IMapSite[4];
        }
        public virtual void Enter()
        {
            Console.WriteLine("Вы вошли в комнату " + RoomNumber);
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