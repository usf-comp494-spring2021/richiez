// Author: Richard Zielinski 
// date: 2/15/21
// project: HW 3
// purpose: making a class libray and testing it with a test project

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace RZielinski_HW_04
{
    public class Server : Computer
    {
        // server also defined with CPUCount 
        public int CPUCount;

        public override void WriteToConsole()
        {
            /// <summary>
            /// The Write to console function taken from the parent class to get the shared variables but also update it with the new CPUCount var
            /// It will then print it to the screen when ran
            /// </summary>
            WriteLine(
                format: "The Server: [Manufacture: {0} ; Model: {1} ; Purpose Code: {2} ; CPU Code: {3} ; CPU Count: {4}]",
                manufacture,
                model,
                purposeCode,
                CPUCode,
                CPUCount
                );
        }
    }
}
