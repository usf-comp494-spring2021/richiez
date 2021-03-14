// Author: Richard Zielinski 
// date: 3/13/21
// project: Midterm
// purpose: Reading in a file and updating it with new information (mean and median) 

using System;

namespace CalculatorLib
{

    /// <summary> 
    /// this class will maintain the needed methods for calculator functionality
    /// <summary> 
    public class Calculator
    {
        /// <summary>
        /// to add a and b together
        /// </summary>
        /// <param name="a">the first number in the equation</param>
        /// <param name="b">the second number in the equation</param>
        /// <returns>the sum of a and b</returns>
        public double Add(double a, double b)
        {
            return (a + b);
        }

        /// <summary>
        /// to subtract a and b 
        /// </summary>
        /// <param name="a">the first number in the equation</param>
        /// <param name="b">the second number in the equation</param>
        /// <returns>the difference of a and b</returns>
        public double Subtract(double a, double b)
        {
            return (a - b);
        }

        /// <summary>
        /// to multiply a and b together
        /// </summary>
        /// <param name="a">the first number in the equation</param>
        /// <param name="b">the second number in the equation</param>
        /// <returns>the product of a and b</returns>
        public double Multiply(double a, double b)
        {
            return (a * b);
        }

        /// <summary>
        /// to divide a and b 
        /// </summary>
        /// <param name="a">the first number in the equation</param>
        /// <param name="b">the second number in the equation</param>
        /// <returns>the quotient of a and b</returns>
        public double Divide(double a, double b)
        {
            return (a / b);
        }

        /// <summary>
        /// to take take the elements of an array and find its average
        /// </summary>
        /// <param name="arr">the array of doubles read in</param>
        /// <param name="size">the amount of elements in the array</param>
        /// <returns>will return a double value which is the average of the array</returns>
        public double Mean(double[] arr, int size)
        {
            double avg;
            double sum = 0;

            for (int i = 0; i < size; i++)
            {
                sum += arr[i];
            }
            avg = (double)sum / size;
            return avg;
        }

        /// <summary>
        /// to take the elements of an array and return the value of the middle
        /// if its an odd numbered array the average of the two middle elements will be found
        /// </summary>
        /// <param name="arr">the array of doubles read in</param>
        /// <param name="size">the amount of elements in the array</param>
        /// <returns>will return a double value which is the median of the array</returns>
        public double Median(double[] arr, int size)
        {
            double med;
            if (size % 2 == 1)
            {
                med = arr[size / 2];
                return med;
            }

            else
            {
                med = (arr[(size - 1) / 2] + arr[size / 2]) / 2.0;
                return med;
            }

        }
    }
}
