using System;
namespace LibraryForLabyrinth
{
    public class WallWithBomb : Wall
    {
        private bool _isDestroyed = false;
        public void Explode()
        {
            if (!_isDestroyed)
            {
                Console.WriteLine("Стена взорвана!");
                _isDestroyed = true;
            }
        }
        public override void Enter()
        {
            if (_isDestroyed)
            {
                Console.WriteLine("Стена разрушена!");
            }
            else
            {
                base.Enter();
            }
        }
    }
}