using NUnit.Framework;
using System;

using Pwrliftr.Calculators;

namespace Pwrliftr.Calculators.Tests
{
    [TestFixture]
    public class WilksCalculatorTests
    {
        [TestCase]
        public void TestMaleCalculation()
        {
            var calculator = new WilksCalculator();
            var result = calculator.Calculate(105, 530, true);
            Assert.AreEqual(316.703385026073, result, 0.00000001);
        }

        [TestCase] 
        public void TestFemaleCalculation()
        {
            var calculator = new WilksCalculator();
            var result = calculator.Calculate(105, 530, false);
            Assert.AreEqual(435.518929833504, result, 0.00000001);
        }
    }
}
