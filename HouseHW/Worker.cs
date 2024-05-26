using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseHW
{
    public class Worker : IWorker
    {
        public void Work(House house)
        {
            foreach (var part in house.Parts)
            {
                if (!part.IsBuild)
                {
                    part.Build();
                    break;
                }
            }
        }
    }
}
