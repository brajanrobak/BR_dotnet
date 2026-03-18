using System;
using System.Collections.Generic;

namespace KalkulatorApp.Kalkulator
{
    public class Calculator
    {
        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Nie mozna dzielic przez zero.");
            }
            else
            {
                return a / b;
            }
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double SumSequence(IEnumerable<double> numbers)
        {
            double sum = 0;
            foreach (double number in numbers)
            {
                sum = sum + number;
            }
            return sum;
        }

        public double AvgSequence(IEnumerable<double> numbers)
        {
            double sum = 0;
            int count = 0;
            foreach (double number in numbers)
            {
                sum = sum + number;
                count = count + 1;
            }
            return sum / count;
        }

        public double MaxSequence(IEnumerable<double> numbers)
        {
            double max = double.MinValue; // Zaczynamy od najmniejszej możliwej liczby
            foreach (double number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            return max;
        }

        public double MinSequence(IEnumerable<double> numbers)
        {
            double min = double.MaxValue; // Zaczynamy od największej możliwej liczby
            foreach (double number in numbers)
            {
                if (number < min)
                {
                    min = number;
                }
            }
            return min;
        }
    }
}