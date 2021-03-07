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
   public class Laptop : Computer 
    {
        //laptop also defined with its screensize 
        public int screenSize;
        
        /// <summary>
        /// The Write to console function taken from the parent class to get the shared variables but also update it with the new screenSize var
        /// It will then print it to the screen when ran
        /// </summary>
        public override void WriteToConsole()
        {
                WriteLine(
                format: "The Laptop: [Manufacture: {0} ; Model: {1} ; Purpose Code: {2} ; CPU Code: {3} ; Screen Size: {4}]",
                manufacture,
                model,
                purposeCode,
                CPUCode,
                screenSize
               );
        }
    }
}
