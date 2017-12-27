using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHomeWork
{
    class Basement:IPart
    {
        public bool IsPartComplete = false;
        public void Build()
        {
            IsPartComplete = true;
            Console.WriteLine("======================================");
        }
    }
}
