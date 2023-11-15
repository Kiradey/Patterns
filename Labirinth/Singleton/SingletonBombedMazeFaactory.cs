using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFabric;
namespace Singleton
{
    public class SingletonBombedMazeFactory : MazeFactory
    {
        private static SingletonBombedMazeFactory? _instance;

        private SingletonBombedMazeFactory() { }

        public static SingletonBombedMazeFactory Instance
        {
            get
            {
                _instance ??= new SingletonBombedMazeFactory();
                return _instance;
            }
        }
    }
}
