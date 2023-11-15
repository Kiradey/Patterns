using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFabric;
namespace Singleton
{
    public class SingletonMazeFactory:MazeFactory
    {
        private static SingletonMazeFactory? _instance;

        private SingletonMazeFactory() { }

        public static SingletonMazeFactory Instance
        {
            get
            {
                _instance ??= new SingletonMazeFactory();
                return _instance;
            }
        }
    }
}
