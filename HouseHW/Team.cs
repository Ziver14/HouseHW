using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseHW
{
   public class Team
    {
        public List<IWorker> workers = new List<IWorker>
    {
        new Worker(),
        new Worker(),
        new Worker(),
        new Worker(),
        new Worker(),
        new Worker(),
        new TeamLeader()
    };

        public void BuildHouse(House house)
        {
            foreach (var worker in workers)
            {
                worker.Work(house);
                if (house.IsComplete)
                {   
                    DrawHouse(house);
                    break;
                }
            }
        }
        private void DrawHouse(House house)
        {
            Console.WriteLine("Рисунок дома:");
            Console.WriteLine("  /\\");
            Console.WriteLine(" /  \\");
            Console.WriteLine("/____\\");
            Console.WriteLine("|  | |");
            Console.WriteLine("|  | |");
            Console.WriteLine("-----");
        }



    }
}
