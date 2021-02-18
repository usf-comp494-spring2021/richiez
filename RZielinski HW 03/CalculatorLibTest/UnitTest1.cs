// Author: Richard Zielinski 
// date: 2/15/21
// project: HW 3
// purpose: making a class libray and testing it with a test project

using CalculatorLib;
using System;
using Xunit;

namespace CalculatorLibTest
{
    // this class was created with the purpose of testing the calculator methods
    public class UnitTest1
    {
        /// <summary>
        /// to add 2 and 4 
        /// </summary>
        /// <param a="2"></param>
        /// <param b="4"></param>
        /// <returns>
        /// this method will return the sum 2 and 4 
        /// </returns>
        [Fact]
        public void Testing2and4()
        {
            double a = 2;
            double b = 4;
            double expected = 6;
            var calc = new Calculator();

            //act 
            double actual = calc.Add(a, b);

            //asset
            Assert.Equal(expected, actual);
        }
        /// <summary>
        /// to subtract 3 and 1 
        /// </summary>
        /// <param a="3"></param>
        /// <param b="1"></param>
        /// <returns>
        /// this method will return the difference of 3 and 1 
        /// </returns>
        [Fact]
        public void Testing1and3()
        {
            double a = 3;
            double b = 1;
            double expected = 2;
            var calc = new Calculator();

            //act 
            double actual = calc.Subtract(a, b);

            //asset
            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// to multiply 2 and 4 
        /// </summary>
        /// <param a="5"></param>
        /// <param b="4"></param>
        /// <returns>
        /// this method will return the product of 5 and 4 
        /// </returns>
        [Fact]
        public void Testing5and4()
        {
            double a = 5;
            double b = 4;
            double expected = 20;
            var calc = new Calculator();

            //act 
            double actual = calc.Multiply(a, b);

            //asset
            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// to divide 10 and 2 
        /// </summary>
        /// <param a="10"></param>
        /// <param b="2"></param>
        /// <returns>
        /// this method will return the quotient of 10 and 2 
        /// </returns>
        [Fact]
        public void Testing2and10()
        {
            double a = 10;
            double b = 2;
            double expected = 5;
            var calc = new Calculator();

            //act 
            double actual = calc.Divide(a, b);

            //asset
            Assert.Equal(expected, actual);
        }
    }
}
