using System;
namespace LibraryForLabyrinth
{
    public class Wall : IMapSite
    {
        public virtual void Enter()
        {
            Console.WriteLine("Вы не можете пройти через стену.");
        }
        public virtual Wall Clone()
        {
            return new Wall();
        }
    }
}
