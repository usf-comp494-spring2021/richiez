// Author: Richard Zielinski 
// date: 2/15/21
// project: HW 3
// purpose: making a class libray and testing it with a test project

using System;
using RZielinski_HW_04;
namespace RZielinski_HW04_Main
{
    /// <summary>
    /// In main three class objects are created 
    /// One for a computer, a laptop, and a server
    /// Each have a set of variables, some inherited and some new, that are defined for each object
    /// They are then printed to the screen and the program ends
    /// </summary>
    class Program
    {
        static void Main(String[] args)
        {
            /// <summary>
            /// An object is made for a computer and printed out to the screen
            /// </summary>
            Computer Computertest = new Computer();
            Computertest.manufacture = "Dell";
            Computertest.model = "Alienware";
            Computertest.purposeCode = "1234";
            Computertest.CPUCode = "5678";
            Computertest.WriteToConsole();

            /// <summary>
            /// An object is made for a laptop and printed out to the screen
            /// </summary>
            Laptop Laptoptest = new Laptop();
            Laptoptest.manufacture = "HP";
            Laptoptest.model = "The Best Laptop Ever";
            Laptoptest.purposeCode = "7346";
            Laptoptest.CPUCode = "7193";
            Laptoptest.screenSize = 13;
            Laptoptest.WriteToConsole();

            /// <summary>
            /// An object is made for a server and printed out to the screen
            /// </summary>
            Server Servertest = new Server();
            Servertest.manufacture = "IBM";
            Servertest.model = "Does IBM still make computers?: The server";
            Servertest.purposeCode = "7412";
            Servertest.CPUCode = "8963";
            Servertest.CPUCount = 3;
            Servertest.WriteToConsole();

        }
    }
}
