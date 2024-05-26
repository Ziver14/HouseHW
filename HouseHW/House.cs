using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseHW
{
    public class House
    {
        public List<IPart> Parts { get; } = new List<IPart>
    {
        new Basement(),
        new Walls(),
        new Door(),
        new Window(),
        new Window(),
        new Roof()
    };

        public bool IsComplete
        {
            get
            {
                return Parts.TrueForAll(part => part.IsBuild);
            }
        }







    }
}
