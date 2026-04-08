using System;

namespace VehicleRentalSystem;

public class Car : Vehicle
{
    public string BodyType { get; set; }

    public Car(int id, string brand, string model, int year, string bodyType)
    {
        Id = id; 
        Brand = brand; 
        Model = model; 
        Year = year; 
        BodyType = bodyType;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"[ID: {Id}] [Car] {Brand} {Model} ({Year}), Body: {BodyType}, Available: {IsAvailable}");
    }
}