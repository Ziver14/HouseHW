using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseHW
{
    public class Roof:IPart
    {
        public bool IsBuild { get; set; }
        public void Build()
        {
            IsBuild = true;
            Console.WriteLine("Крыша построена");
        }
        
    }
}
