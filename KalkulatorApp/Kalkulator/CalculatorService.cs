using System;
using System.Collections.Generic;
using KalkulatorApp.Kalkulator;

namespace KalkulatorApp.Kalkulator
{
    public class CalculatorService
    {
        private ScientificCalculator _scientificCalculator = new ScientificCalculator();

        public void Run()
        {
            Console.WriteLine("Kalkulator naukowy w C#");
            Console.WriteLine("\nWybierz operację: +, -, *, /, ^, sqrt, log, sum, avg, max, min");
            string operation = Console.ReadLine();

            if (operation == "+" || operation == "-" || operation == "*" || operation == "/" || operation == "^")
            {
                Console.WriteLine("Podaj pierwsza liczbe:");
                double a = double.Parse(Console.ReadLine());
                
                Console.WriteLine("Podaj druga liczbe:");
                double b = double.Parse(Console.ReadLine());

                switch (operation)
                {
                    case "+":
                        double wynikDodawania = _scientificCalculator.calculator.Add(a, b);
                        Console.WriteLine("Wynik: " + wynikDodawania);
                        break;
                    case "-":
                        double wynikOdejmowania = _scientificCalculator.calculator.Subtract(a, b);
                        Console.WriteLine("Wynik: " + wynikOdejmowania);
                        break;
                    case "*":
                        double wynikMnozenia = _scientificCalculator.calculator.Multiply(a, b);
                        Console.WriteLine("Wynik: " + wynikMnozenia);
                        break;
                    case "/":
                        double wynikDzielenia = _scientificCalculator.calculator.Divide(a, b);
                        Console.WriteLine("Wynik: " + wynikDzielenia);
                        break;
                    case "^":
                        double wynikPotegi = _scientificCalculator.Power(a, b);
                        Console.WriteLine("Wynik: " + wynikPotegi);
                        break;
                }
            }
            else if (operation == "sqrt" || operation == "log")
            {
                Console.WriteLine("Podaj liczbe:");
                double a = double.Parse(Console.ReadLine());

                switch (operation)
                {
                    case "sqrt":
                        double wynikPierwiastka = _scientificCalculator.SquareRoot(a);
                        Console.WriteLine("Wynik: " + wynikPierwiastka);
                        break;
                    case "log":
                        double wynikLogarytmu = _scientificCalculator.Log(a);
                        Console.WriteLine("Wynik: " + wynikLogarytmu);
                        break;
                }
            }
            else if (operation == "sum" || operation == "avg" || operation == "max" || operation == "min")
            {
                Console.WriteLine("Podaj liczby oddzielone spacja:");
                string input = Console.ReadLine();
                
                string[] textNumbers = input.Split(' ');
                
                List<double> numbers = new List<double>();
                
                foreach (string text in textNumbers)
                {
                    numbers.Add(double.Parse(text));
                }

                switch (operation)
                {
                    case "sum":
                        Console.WriteLine("Wynik: " + _scientificCalculator.calculator.SumSequence(numbers));
                        break;
                    case "avg":
                        Console.WriteLine("Wynik: " + _scientificCalculator.calculator.AvgSequence(numbers));
                        break;
                    case "max":
                        Console.WriteLine("Wynik: " + _scientificCalculator.calculator.MaxSequence(numbers));
                        break;
                    case "min":
                        Console.WriteLine("Wynik: " + _scientificCalculator.calculator.MinSequence(numbers));
                        break;
                }
            }
            else
            {
                Console.WriteLine("Nieznana operacja!");
            }
        }
    }
}