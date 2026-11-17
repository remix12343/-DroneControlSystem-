using System;


namespace DroneControlSystem
{
    class Program
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
}
    
