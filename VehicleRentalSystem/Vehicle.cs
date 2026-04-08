namespace VehicleRentalSystem;

public abstract class Vehicle : IReservable
{
    public int Id { get; set; } 
    public string Brand { get; set; } 
    public string Model { get; set; } 
    public int Year { get; set; } 
    public bool IsAvailable { get; protected set; } = true; 
    
    public abstract void DisplayInfo(); 

    public virtual void Reserve(string customer) 
    {
        IsAvailable = false;
    }

    public virtual void CancelReservation() 
    {
        IsAvailable = true;
    }

    bool IReservable.IsAvailable() => IsAvailable; 
}