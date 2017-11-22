using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pwrliftr.Calculators.Tests
{
    [TestFixture]
    public class PlateCalculatorTests
    {
        [TestCase]
        public void TestCalculation()
        {
            //arrange
            var sut = new PlateCalculator();
            var plateSet = new List<double>() { 25, 25, 25, 25, 25, 25, 20, 15, 10, 5, 2.5, 1.25, 0.5, 0.25 };
            //act
            var result = sut.Calculate(plateSet, 320, false);
            var expected = new List<double>() { 25, 25, 25, 25, 25, 20, 2.5};
            //assert
            Assert.AreEqual(expected, result);
        }


        [TestCase]
        public void TestRecordWeight_332half()
        {
            //arrange
            var sut = new PlateCalculator();
            var plateSet = new List<double>() { 25, 25, 25, 25, 25, 25, 20, 15, 10, 5, 2.5, 1.25, 0.5, 0.25 };

            //act
            var result = sut.Calculate(plateSet, 435, true);
            var expected = new List<double>() { 25, 25, 25, 25, 25, 25, 20, 15, 10, 5, 2.5, 1.25, 0.5, 0.25 };
            //assert
            Assert.AreEqual(expected, result);
        }

        [TestCase]
        public void Test332Set()
        {
            //arrange
            var sut = new PlateCalculator();
            //actually half a plate set
            var plateSet = new List<double>() { 25, 25, 25, 25, 20, 15, 10, 5, 2.5, 1.25 };

            //act
            var result = sut.Calculate(plateSet, 332.5, false);
            var expected = new List<double>() { 25, 25, 25, 25, 20, 15, 10, 5, 2.5, 1.25 };
            //assert
            Assert.AreEqual(expected, result);
        }

        [TestCase]
        public void Test334Set()
        {
            //arrange
            var sut = new PlateCalculator();
            //actually half a plate set
            var plateSet = new List<double>() { 25, 25, 25, 25, 20, 15, 10, 5, 2.5, 1.25, 0.5, 0.25 };

            //act
            var result = sut.Calculate(plateSet, 334, true);
            var expected = new List<double>() { 25, 25, 25, 25, 20, 15, 10, 5, 2.5, 1.25, 0.5, 0.25 };
            //assert
            Assert.AreEqual(expected, result);
        }

        [TestCase]
        public void Test682half()
        {
            //arrange
            var sut = new PlateCalculator();
            //actually half a plate set
            var plateSet = new List<double>() { 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 15, 10, 5, 2.5, 1.25};

            //act
            var result = sut.Calculate(plateSet, 592.5, true);
            var expected = new List<double>() { 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 15, 10, 5, 2.5, 1.25 };
            //assert
            Assert.AreEqual(expected, result);
        }
    }
}
