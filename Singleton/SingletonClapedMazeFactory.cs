using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFabric;
namespace Singleton
{
    public class SingletonClapedMazeFactory : MazeFactory
    {
        private static SingletonClapedMazeFactory? _instance;
        private SingletonClapedMazeFactory() { }
        public static SingletonClapedMazeFactory Instance
        {
            get
            {
                _instance ??= new SingletonClapedMazeFactory();
                return _instance;
            }
        }
    }
}
