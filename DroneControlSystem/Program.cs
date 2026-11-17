using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneControlSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Drone[] drones = new Drone[]
 {
            static void Main()
            {
                Drone[] drones = new Drone[]
                {
            new Drone("DJI Mini 3", 85),
            new Drone("Autel EVO Lite", 45),
            new Drone("Parrot Anafi", 15)
                };

                foreach (Drone drone in drones)
                {
                    drone.PrintInfo();

                    if (drone.Battery < 20)
                    {
                        Console.WriteLine("  Внимание: низкий заряд батареи! Требуется зарядка.");
                    }
                    Console.WriteLine();
                }
            }
        }

    };
        }
    }
}
