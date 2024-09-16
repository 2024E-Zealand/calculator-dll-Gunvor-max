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
        [TestMethod()]
        [DataRow(1,1,2)]
        [DataRow((int.MaxValue-1),1,int.MaxValue)]
        public void CalculateAdditionTest(double x, double y, double result)
        {
            //Act
            var expectedResult = result;
            var actualResult = Calculator.CalculateAddition(x, y);
            //Assert
            Assert.AreEqual(expectedResult,actualResult);
        }

        [TestMethod()]
        [DataRow(1, 1, 0)]
        [DataRow(int.MaxValue, 1,(int.MaxValue - 1))]
        public void CalculateSubtractionTest(double x, double y, double result)
        {
            //Act
            var expectedResult = result;
            var actualResult = Calculator.CalculateSubtraction(x, y);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}