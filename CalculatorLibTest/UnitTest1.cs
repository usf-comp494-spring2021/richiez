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
        // testing the addition method by adding 2 and 4 to get 6
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
        // testing the subtraction method by subtracting 3 and 1 to get 2
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

        // testing the multiplication method by multiplying 5 and 4 to get 20
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

        // testing the divide method by dividing 10 and 2 to get 5
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
