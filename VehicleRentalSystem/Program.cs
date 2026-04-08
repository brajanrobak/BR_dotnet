using System;
using VehicleRentalSystem;

var company = new RentalCompany();

company.AddVehicle(new Car(1, "Toyota", "Corolla", 2020, "Sedan"));
company.AddVehicle(new Car(2, "Ford", "Mustang", 2022, "Coupe"));
company.AddVehicle(new Motorcycle(3, "Yamaha", "MT-07", 2021, 689));

company.OnNewReservation += message => Console.WriteLine(message);

while (true)
{
    Console.WriteLine("\n=== SYSTEM WYPOŻYCZALNI POJAZDÓW ===");
    Console.WriteLine("1. Wyświetl dostępne pojazdy");
    Console.WriteLine("2. Zarezerwuj pojazd");
    Console.WriteLine("3. Anuluj rezerwację");
    Console.WriteLine("4. Wyszukaj rezerwacje klienta");
    Console.WriteLine("5. Wyjście");
    Console.Write("Wybierz opcję: ");
    
    var choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.WriteLine("\n--- Dostępne pojazdy ---");
            company.ListAvailableVehicles();
            break;
        case "2":
            Console.Write("Podaj ID pojazdu do rezerwacji: ");
            if (int.TryParse(Console.ReadLine(), out int vehicleId))
            {
                Console.Write("Podaj imię i nazwisko klienta: ");
                string customer = Console.ReadLine();
                company.ReserveVehicle(vehicleId, customer);
            }
            break;
        case "3":
            Console.Write("Podaj ID rezerwacji do anulowania: ");
            if (int.TryParse(Console.ReadLine(), out int resId))
            {
                company.CancelReservation(resId);
            }
            break;
        case "4":
            Console.Write("Podaj imię i nazwisko klienta: ");
            string searchCustomer = Console.ReadLine();
            company.SearchCustomerReservations(searchCustomer);
            break;
        case "5":
            return;
        default:
            Console.WriteLine("Nieznana opcja, spróbuj ponownie.");
            break;
    }
}