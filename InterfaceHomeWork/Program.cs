using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            
            House house = new House();
            Team team = new Team();
            TeamLeader teamLeader = new TeamLeader();
            for (int i = 0; i < 6; i++)
            {
                team.Work(house);
            }

            teamLeader.Work(house);           
            Console.ReadKey();
        }
    }
}
