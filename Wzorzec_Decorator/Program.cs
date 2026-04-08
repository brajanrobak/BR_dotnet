using System;

// 1. Wspólny kontrakt dla wszystkich napojów i dodatków
public interface IBeverage
{
    string GetDescription();
    double GetCost();
}

// 2. Nasz obiekt docelowy (Concrete Component)
public class Espresso : IBeverage
{
    public string GetDescription() => "Espresso";
    public double GetCost() => 10.0;
}

// 3. Abstrakcyjna klasa bazowa dla wszystkich dekoratorów
// Kluczowe: Przechowuje obiekt, który dekoruje
public abstract class BeverageDecorator : IBeverage
{
    protected IBeverage _beverage;

    public BeverageDecorator(IBeverage beverage)
    {
        _beverage = beverage;
    }

    // Domyślnie tylko wywołuje metodę na "opakowanym" obiekcie
    public virtual string GetDescription() => _beverage.GetDescription();
    public virtual double GetCost() => _beverage.GetCost();
}

// 4. Konkretny dodatek (Concrete Decorator) - Mleko
public class MilkDecorator : BeverageDecorator
{
    public MilkDecorator(IBeverage beverage) : base(beverage) { }

    // Rozszerzamy działanie: dodajemy opis i podnosimy cenę
    public override string GetDescription() => base.GetDescription() + ", Mleko";
    public override double GetCost() => base.GetCost() + 2.5;
}

// 5. Prezentacja działania w programie
class Program
{
    static void Main()
    {
        // Krok 1: Tworzymy czystą kawę
        IBeverage myCoffee = new Espresso();
        
        // Krok 2: Opakowujemy naszą kawę w dekorator Mleka
        // myCoffee = nowa warstwa Mleka nałożona na (stare myCoffee)
        myCoffee = new MilkDecorator(myCoffee); 
        
        Console.WriteLine($"{myCoffee.GetDescription()} | Całkowity koszt: {myCoffee.GetCost()} PLN");
        // Wynik na konsoli: Espresso, Mleko | Całkowity koszt: 12.5 PLN
    }
}