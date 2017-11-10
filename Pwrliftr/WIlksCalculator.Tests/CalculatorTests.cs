using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WilksCalculator;

namespace WIlksCalculator.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void GivenIProvideValidParameters_ShouldReturnCorrectResponse()
        {
            var calculator = new WilksCalculator.WilksCalculator();
            var result = calculator.Calculate(105, 530);
            Assert.AreEqual(Math.Round(316.703385026073, 2), Math.Round(result, 2));
        }
    }
}
