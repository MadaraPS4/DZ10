using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHomeWork
{
    class Roof:IPart
    {
        public bool IsPartComplete = false;


        public void Build()
        {
            IsPartComplete = true;
            Console.WriteLine("            //          \n" +
                   "          /////         \n" +
                   "        ////////        \n" +
                   "      ///////////       \n" +
                   "    //////////////      \n");
        }
    }
}
