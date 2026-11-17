using System;

class Drone
{
    public string Model { get; set; }
    public int Battery { get; set; }

    public Drone(string model, int battery)
    {
        Model = model;
        Battery = battery;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Модель: {Model}, заряд: {Battery}%");
    }
}


