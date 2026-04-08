using NUnit.Framework;
using VehicleRentalSystem;

namespace VehicleRentalSystem.Tests;

[TestFixture]
public class RentalTests
{
    private RentalCompany _company;

    [SetUp]
    public void Setup()
    {
        _company = new RentalCompany();
    }

    [Test]
    public void ReserveVehicle_ShouldChangeAvailabilityToFalse()
    {
        var car = new Car(1, "Toyota", "Corolla", 2020, "Sedan");
        _company.AddVehicle(car);
        
        _company.ReserveVehicle(1, "John Doe");
        
        Assert.That(car.IsAvailable, Is.False);
    }

    [Test]
    public void CancelReservation_ShouldMakeVehicleAvailableAgain()
    {
        var car = new Car(2, "Ford", "Focus", 2019, "Hatchback");
        _company.AddVehicle(car);
        _company.ReserveVehicle(2, "Anna Nowak"); 
        
        _company.CancelReservation(1);
        
        Assert.That(car.IsAvailable, Is.True);
    }
}