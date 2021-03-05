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
        public int screenSize;
        
        public void WriteToConsole()
        {
                WriteLine(
                format: "{0} {1} {2} {3} {4}",
                manufacture,
                model,
                purposeCode,
                CPUCode,
                screenSize
               );
        }
    }
}
