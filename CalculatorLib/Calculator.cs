using System;

namespace CalculatorLib
{

    // this class will maintain the needed methods for calculator functionality 
    public class Calculator
    {
        /*
         * this method will return the sum a and b 
         * param: value of a 
         * param: value of b 
        */
        public double Add(double a, double b)
        {
            return (a + b);
        }

        /*
         * purpose: this method will return the difference of a and b 
         * param: value of a 
         * param: value of b 
        */
        public double Subtract(double a, double b)
        {
            return (a - b);
        }

        /*
         * this method will return the product of a and b 
         * param: value of a 
         * param: value of b 
        */
        public double Multiply(double a, double b)
        {
            return (a * b);
        }

        /*
         * this method will return the quotient of a and b 
         * param: value of a 
         * param: value of b 
        */
        public double Divide(double a, double b)
        {
            return (a / b);
        }
    }
}
