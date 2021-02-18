using System;

namespace CalculatorLib
{

    /// <summary> 
    /// this class will maintain the needed methods for calculator functionality
    /// <summary> 
    public class Calculator
    {
        /// <summary>
        /// to add a and b 
        /// </summary>
        /// <param a="a double"></param>
        /// <param b="a double"></param>
        /// <returns>
        /// this method will return the sum a and b 
        /// </returns>
        public double Add(double a, double b)
        {
            return (a + b);
        }

        /// <summary>
        /// to subtract a and b 
        /// </summary>
        /// <param a="a double"></param>
        /// <param b="a double"></param>
        /// <returns>
        /// this method will return the difference of a and b 
        /// </returns>
        public double Subtract(double a, double b)
        {
            return (a - b);
        }

        /// <summary>
        /// to multiply a and b 
        /// </summary>
        /// <param a="a double"></param>
        /// <param b="a double"></param>
        /// <returns>
        /// this method will return the product of a and b 
        /// </returns>
        public double Multiply(double a, double b)
        {
            return (a * b);
        }

        /// <summary>
        /// to divide a and b 
        /// </summary>
        /// <param a="a double"></param>
        /// <param b="a double"></param>
        /// <returns>
        /// this method will return the quotient a and b 
        /// </returns>
        public double Divide(double a, double b)
        {
            return (a / b);
        }
    }
}
