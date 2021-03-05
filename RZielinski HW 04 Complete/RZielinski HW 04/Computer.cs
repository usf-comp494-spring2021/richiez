// Author: Richard Zielinski 
// date: 2/15/21
// project: HW 3
// purpose: making a class libray and testing it with a test project

using System;
using static System.Console;
namespace RZielinski_HW_04
{  
   
    public class Computer
    { 
        public string manufacture, model, purposeCode, CPUCode;

        public Computer()
        {
            manufacture = "";
            model = "";
            purposeCode = "";
            CPUCode = "";
        }

        public Computer(string usrManufacture, string usrModel, string usrPurposeCode, string usrCPUCode)
        {
            manufacture = usrManufacture;
            model = usrModel;
            purposeCode = usrPurposeCode;
            CPUCode = usrCPUCode;
        }

        public void WriteToConsole()
        {
            WriteLine(
                format: "{0} {1} {2} {3}",
                manufacture,
                model,
                purposeCode,
                CPUCode
                );
        }

    }
}
