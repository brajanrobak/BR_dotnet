using System;

namespace KalkulatorApp.Kalkulator
{
    public class ScientificCalculator
    {
        public Calculator calculator = new Calculator();

        public double Power(double a, double b)
        {
            return Math.Pow(a, b);
        }

        public double SquareRoot(double a)
        {
            if (a < 0)
            {
                throw new ArgumentException("Liczba nie moze byc ujemna");
            }
            else
            {
                return Math.Sqrt(a);
            }
        }

        public double Log(double a)
        {
            return Math.Log(a);
        }
    }
}