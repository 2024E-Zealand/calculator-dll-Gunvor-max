using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorClassLibrary.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        Calculator TestCalculator { get; set; }
        [TestInitialize]
        public void beforeeachtest()
        {
            //Arrange
            Calculator calculator = new Calculator();
            TestCalculator = calculator;
        }


        [TestMethod()]
        [DataRow(1,1,2)]
        public void CalculateAdditionTest(double x, double y, double result)
        {
            //Act
            var expectedResult = result;
            var actualResult = TestCalculator.CalculateAddition(x, y);
            //Assert
            Assert.AreEqual(expectedResult,actualResult);
        }
    }
}