using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHomeWork
{
    class Team:IWorker
    {
        Worker[] worker;
        public Team()
        {
            worker = new Worker[6];
        }

        public bool Work(House house)
        {
            if (house.basement.IsPartComplete == false)
            {

                house.basement.Build();
                return true;


            }
            else if (house.door.IsPartComplete == false)
            {

                house.door.Build();
                return true;


            }

            for (int i = 0; i < 4; i++)
            {
                if (house.wall.IsPartComplete == false)
                {
                    house.wall.Build();
                }
            }
            for (int i = 0; i < 4; i++)
            {
                if (house.window.IsPartComplete == false)
                {
                    house.window.Build();
                }
            }
            if (house.roof.IsPartComplete == false)
            {
                house.roof.Build();
                return true;
            }
            return true;
        }
    }

}
