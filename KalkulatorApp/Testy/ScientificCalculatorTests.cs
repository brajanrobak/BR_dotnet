using NUnit.Framework;
using KalkulatorApp.Kalkulator;

    [TestFixture]
    public class ScientificCalculatorTests
    {
        [Test]
        public void Test_Potegowanie()
        {
            ScientificCalculator sci = new ScientificCalculator();
            double wynik = sci.Power(2, 3);
            Assert.AreEqual(8, wynik);
        }

        [Test]
        public void Test_Pierwiastkowanie()
        {
            ScientificCalculator sci = new ScientificCalculator();
            double wynik = sci.SquareRoot(16);
            Assert.AreEqual(4, wynik);
        }

        [Test]
        public void Test_PierwiastekLiczbaUjemna()
        {
            ScientificCalculator sci = new ScientificCalculator();
            Assert.Throws<ArgumentException>(() => sci.SquareRoot(-5));
        }

        [Test]
        public void Test_Logarytm()
        {
            ScientificCalculator sci = new ScientificCalculator();
            double wynik = sci.Log(1);
            Assert.AreEqual(0, wynik);
        }
    }

