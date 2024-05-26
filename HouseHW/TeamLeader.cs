using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseHW
{
    public class TeamLeader : IWorker
    {
        public void Work(House house)
        {
            Console.WriteLine("Отчёт о строительстве:");
            foreach (var part in house.Parts)
            {
                Console.WriteLine($"{part.GetType().Name}: {(part.IsBuild ? "Построено" : "Не построено")}");
            }
        }


    }
    }
