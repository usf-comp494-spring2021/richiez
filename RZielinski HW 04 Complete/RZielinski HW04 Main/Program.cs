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
            Computer test = new Computer();
            test.manufacture = "Dell";
            test.model = "Alienware";
            test.purposeCode = "1234";
            test.CPUCode = "5678";
            test.WriteToConsole();

            /// <summary>
            /// An object is made for a laptop and printed out to the screen
            /// </summary>
            Laptop test2 = new Laptop();
            test2.manufacture = "HP";
            test2.model = "The Best Laptop Ever";
            test2.purposeCode = "7346";
            test2.CPUCode = "7193";
            test2.screenSize = 13;
            test2.WriteToConsole();

            /// <summary>
            /// An object is made for a server and printed out to the screen
            /// </summary>
            Server test3 = new Server();
            test3.manufacture = "IBM";
            test3.model = "Does IBM still make computers?: The server";
            test3.purposeCode = "7412";
            test3.CPUCode = "8963";
            test3.CPUCount = 3;
            test3.WriteToConsole();

        }
    }
}
