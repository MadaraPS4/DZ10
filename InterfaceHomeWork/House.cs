using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHomeWork
{
    class House
    {
        public Basement basement;
        public Door door;
        public Roof roof;
        public Wall wall;
        public Window window;

        public House()
        {
            wall = new Wall();
            window = new Window();
            basement = new Basement();
            door = new Door();
            roof = new Roof();
        }
    }
}
