using System;

namespace VehicleRentalSystem;

public class Reservation
{
    public int ReservationId { get; set; }
    public Vehicle ReservedVehicle { get; set; }
    public string Customer { get; set; }
    public DateTime ReservationDate { get; set; }

    public override string ToString()
    {
        return $"Rezerwacja #{ReservationId}: {ReservedVehicle.Brand} dla {Customer} z dnia {ReservationDate}";
    }
}