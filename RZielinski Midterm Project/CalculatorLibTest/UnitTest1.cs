// Author: Richard Zielinski 
// date: 3/13/21
// project: Midterm
// purpose: Reading in a file and updating it with new information (mean and median) 

using CalculatorLib;
using System;
using Xunit;

namespace CalculatorLibTest
{
    // this class was created with the purpose of testing the calculator methods
    public class UnitTest1
    {
        /// <summary>
        /// finding the mean of an array 
        /// </summary>
        [Fact]
        public void TestingMean()
        {
            double[] arr = { 0, 1, 2, 3, 4, 5, 6 };
            int size = 7;
            double expected = 3;
            var calc = new Calculator();

            double actual = calc.Mean(arr, size);

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// finding the median of an array that has an odd number of elements
        /// </summary>
        [Fact]
        public void TestingMedianOddArr()
        {
            double[] arr = { 0, 1, 2, 3, 4, 5, 6 };
            int size = 7;
            double expected = 3;
            var calc = new Calculator();

            double actual = calc.Median(arr, size);

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// finding the median of an array that has an even number of elements
        /// </summary>
        [Fact]
        public void TestingMedianEvenArr()
        {
            double[] arr = { 0, 1, 2, 3, 4, 5 };
            int size = 6;
            double expected = 2.5;
            var calc = new Calculator();

            double actual = calc.Median(arr, size);

            Assert.Equal(expected, actual);
        }
    }
}
