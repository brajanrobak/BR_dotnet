using System;

namespace VehicleRentalSystem;

public class Motorcycle : Vehicle
{
    public int EngineCapacity { get; set; }

    public Motorcycle(int id, string brand, string model, int year, int engineCapacity)
    {
        Id = id; 
        Brand = brand; 
        Model = model; 
        Year = year; 
        EngineCapacity = engineCapacity;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"[ID: {Id}] [Motorcycle] {Brand} {Model} ({Year}), Engine: {EngineCapacity}cc, Available: {IsAvailable}");
    }
}