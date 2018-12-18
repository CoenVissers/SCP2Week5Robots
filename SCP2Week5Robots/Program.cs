using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCP2Week5Robots
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot Robo = new Robot(3, 3, 4);
            List<Location> Robots = new List<Location>();
            Robo.PlaceRobots(Robots);
            List<int> Mechanic = new List<int>();
            Mechanic.Add(0);
            Mechanic.Add(0);
            bool GameWon = false;
            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7}", Robots[0], Robots[1], Robots[2], Robots[3], Robots[4], Robots[5], Robots[6], Robots[7]);
            for (int row = 0; row < Robo.FacHeight; row++)
            {
                for (int col = 0; col < Robo.FacWidth; col++)
                {
                    bool Postaken = false;
                    for (int i = 0; i < Robo.NumberOfRobots; i++)
                    {
                        if (Robots[i].y == row && Robots[i].x == col)
                        {
                            Postaken = true;
                            if (Mechanic[0] == Robots[i].y && Mechanic[1] == Robots[i].x)
                            {
                                Robots.RemoveAt(2*i);
                                Robots.RemoveAt(2*i+1);
                                Robo.NumberOfRobots -= 1;
                                bool isEmpty = !Robots.Any();
                                if (isEmpty)
                                {
                                    GameWon = true;
                                    return;
                                }
                            }
                        }
                    }
                    if (Mechanic[0] == row && Mechanic[1] == col)
                    {
                        Console.Write('M');
                    }
                    else if (Postaken)
                    {
                        Console.Write('R');
                    }
                    else if (!Postaken)
                    {
                        Console.Write(".");
                    }
                }
                Console.Write("\n");
            }
            if (GameWon)
            {
                Console.WriteLine("You win!");
            }
            Console.WriteLine("{0} {1} {2} {3} {4} {5}", Robots[0], Robots[1], Robots[2], Robots[3], Robots[4], Robots[5]);
            Console.ReadLine();
        }
    }
}
