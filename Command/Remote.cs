using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Remote
    {
        private Dictionary<int, (ICommand Remult, ICommand Undo)> _command = new Dictionary<int, (ICommand, ICommand)>();
        private Stack<ICommand> _undo = new();
        public void Add(int number, ICommand remult, ICommand undo)
        {
            _command.Add(number, (remult, undo));
        }
        public void Execute(int number)
        {
            if (_command.ContainsKey(number))
            {
                _command[number].Remult.Execute();
                _undo.Push(_command[number].Undo);
            }
            else
            {
                throw new ArgumentException(nameof(number), "Кнопка не найдена!");
            }
        }
        public void Undo()
        {
            if (_undo.Count > 0)
            {
                _undo.Pop().Execute();
            }
            else
            {
                Console.WriteLine("Нет выполненных команд для отмены!");
            }
        }
    }
}