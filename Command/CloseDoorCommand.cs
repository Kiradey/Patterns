using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class CloseDoorCommand : ICommand
    {
        private Door _door;
        public CloseDoorCommand(Door door)
        {
            if (door == null) { throw new ArgumentNullException(nameof(door), "Пустое значение!"); }
            _door = door;
        }
        public void Execute()
        {
            _door.Close();
        }
    }
}
