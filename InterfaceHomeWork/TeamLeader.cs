using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHomeWork
{
    class TeamLeader:IWorker
    {
        public bool Work(House house)
        {
            int countСorrectly = 0;
            Console.WriteLine("Отчет");
            if (house.basement.IsPartComplete == true)
            {
                Console.WriteLine("Фундамент построен");
                countСorrectly++;
            }
            if (house.door.IsPartComplete == true)
            {
                Console.WriteLine("Дверь построена");
                countСorrectly++;
            }
            for (int i = 1; i < 5; i++)
            {
                if (house.wall.IsPartComplete == true)
                {
                    Console.WriteLine(i + " стена построена");
                    countСorrectly++;
                }
            }
            for (int i = 1; i < 5; i++)
            {
                if (house.window.IsPartComplete == true)
                {
                    Console.WriteLine(i + " окно построено");
                    countСorrectly++;

                }
            }
            if (house.roof.IsPartComplete == true)
            {
                Console.WriteLine("Крыша построена");
                countСorrectly++;
            }
            if (countСorrectly == 11)
            {
                Console.WriteLine("Все части дома построены");
                return true;

            }
            else
            {
                Console.WriteLine("Ничего пока не построено");
                return false;
            }
        }
    }

}
