using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCP2Week5Robots
{
    class Robot
    {
        public int FacHeight { get; set; }
        public int FacWidth { get; set; }
        public int NumberOfRobots { get; set; }
        
        public List<Location> Robots { get; set; }

        public Robot(int facheight, int facwidth, int numberofrobots)
        {
            this.FacHeight = facheight;
            this.FacWidth = facwidth;
            this.NumberOfRobots = numberofrobots;
        }

        public List<int> PlaceRobots(List<Location> robots)
        {
            this.Robots = robots;
            Random rnd = new Random();
            Location newLocation = new Location( rnd.Next(0, FacHeight), rnd.Next(0, FacWidth));
            Robots.Add(newLocation);

            int length = 1;
            bool CantAdd = false;
            int n = 1;
            int max = 30;
            for (int i = 1; i < NumberOfRobots; i++)
            {
                while (n < max)
                {
                    CantAdd = false;
                    newLocation = new Location(rnd.Next(0, FacHeight), rnd.Next(0, FacWidth));
                    for (int j = 0; j < length; j++)
                    {
                        if (newLocation.x == Robots[j].x && newLocation.y == Robots[j].y)
                        {
                            CantAdd = true;
                        }
                    }
                    if (CantAdd)
                    {
                        n += 1;
                    }
                    else if (!CantAdd)
                    {
                        Robots.Add(newLocation);
                        length += 1;
                        break;
                    }
                }
                if (CantAdd)
                {
                    Console.WriteLine("Space is too small or there are too many robots");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }
            return Robots;
        }

    }
}
