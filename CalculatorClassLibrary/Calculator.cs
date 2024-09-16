using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorClassLibrary
{
    public class Calculator
    {
        public Calculator()
        {
            
        }

        /// <summary>
        /// Calculate addition
        /// </summary>
        /// <param name="x">First number</param>
        /// <param name="y">Second number</param>
        /// <returns>Sum of first and second number</returns>
        public static double CalculateAddition(double x, double y)
        {
            return x + y;
        }

        /// <summary>
        /// Calculate subtraction
        /// </summary>
        /// <param name="x">First number</param>
        /// <param name="y">Second number</param>
        /// <returns>first number subtraction with second number</returns>
        public static double CalculateSubtraction(double x, double y)
        {
            return x - y;
        }
    }
}
