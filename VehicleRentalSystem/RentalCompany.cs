using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleRentalSystem;

public class RentalCompany
{
    private List<Vehicle> vehicles = new List<Vehicle>();
    private List<Reservation> reservations = new List<Reservation>();

    public event Action<string> OnNewReservation;

    public void AddVehicle(Vehicle vehicle) => vehicles.Add(vehicle);

    public void ReserveVehicle(int vehicleId, string customer)
    {
        var vehicle = vehicles.FirstOrDefault(v => v.Id == vehicleId && v.IsAvailable);
        if (vehicle != null)
        {
            vehicle.Reserve(customer);
            var reservationId = reservations.Count + 1;
            reservations.Add(new Reservation 
            { 
                ReservationId = reservationId, 
                ReservedVehicle = vehicle, 
                Customer = customer, 
                ReservationDate = DateTime.Now 
            });

            OnNewReservation?.Invoke($"\n[SYSTEM] Nowa rezerwacja #{reservationId} dla {customer} (Pojazd: {vehicle.Brand} {vehicle.Model})");
        }
        else
        {
            Console.WriteLine("\n[BŁĄD] Pojazd o podanym ID nie istnieje lub jest już zarezerwowany.");
        }
    }
    
    public void CancelReservation(int reservationId)
    {
        var reservation = reservations.FirstOrDefault(r => r.ReservationId == reservationId);
        if (reservation != null)
        {
            reservation.ReservedVehicle.CancelReservation(); 
            reservations.Remove(reservation);
            Console.WriteLine($"\n[SUKCES] Anulowano rezerwację #{reservationId}. Pojazd znów jest dostępny.");
        }
        else
        {
            Console.WriteLine($"\n[BŁĄD] Nie znaleziono rezerwacji o ID #{reservationId}.");
        }
    }
    
    public void SearchCustomerReservations(string customer)
    {
        var customerReservations = reservations
            .Where(r => r.Customer.Equals(customer, StringComparison.OrdinalIgnoreCase))
            .ToList();

        if (customerReservations.Any())
        {
            Console.WriteLine($"\nRezerwacje klienta {customer}:");
            customerReservations.ForEach(r => Console.WriteLine(r.ToString()));
        }
        else
        {
            Console.WriteLine($"\nBrak aktywnych rezerwacji dla klienta: {customer}");
        }
    }

    public void ListAvailableVehicles()
    {
        var available = vehicles.GetAvailableVehicles();
        if (available.Any())
        {
            available.ForEach(v => v.DisplayInfo());
        }
        else
        {
            Console.WriteLine("Brak dostępnych pojazdów w tej chwili.");
        }
    }
}