using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class OpenDoorCommand : ICommand
    {
        private Door _door;
        public OpenDoorCommand(Door door)
        {
            if (door == null) { throw new ArgumentNullException(nameof(door), "Дверь не может принимать значение null!"); }
            _door = door;
        }
        public void Execute()
        {
            _door.Open();
        }
    }
}
