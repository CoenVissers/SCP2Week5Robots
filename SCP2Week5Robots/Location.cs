using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCP2Week5Robots
{
    class Location
    {
        public int x { get; set; }
        public int y { get; set; }

        public Location(int y, int x)
        {
            this.x = x;
            this.y = y;
        }
    }
}
