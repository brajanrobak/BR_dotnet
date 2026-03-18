using System;
using KalkulatorApp.Kalkulator;

namespace KalkulatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorService service = new CalculatorService();
            service.Run();
        }
    }
}