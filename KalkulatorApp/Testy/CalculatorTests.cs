using NUnit.Framework;
using KalkulatorApp.Kalkulator;

[TestFixture]
public class CalculatorTests
{
    [Test]
    public void Test_Dodawanie()
    {
        Calculator calc = new Calculator();
        double wynik = calc.Add(5, 5);
        Assert.AreEqual(10, wynik);
    }

    [Test]
    public void Test_Odejmowanie()
    {
        Calculator calc = new Calculator();
        double wynik = calc.Subtract(10, 3);
        Assert.AreEqual(7, wynik);
    }

    [Test]
    public void Test_DzieleniePrzezZero()
    {
        Calculator calc = new Calculator();
        Assert.Throws<DivideByZeroException>(() => calc.Divide(10, 0));
    }

    [Test]
    public void Test_SumaListy()
    {
        Calculator calc = new Calculator();
        List<double> liczby = new List<double> { 1, 2, 3 };
        double wynik = calc.SumSequence(liczby);
        Assert.AreEqual(6, wynik);
    }

    [Test]
    public void Test_SredniaListy()
    {
        Calculator calc = new Calculator();
        List<double> liczby = new List<double> { 2, 4, 6 };
        double wynik = calc.AvgSequence(liczby);
        Assert.AreEqual(4, wynik);
    }
}
