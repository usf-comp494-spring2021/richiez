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

        /// <summary>
        /// This is the default contructor that will give the object of the class the default values of blank 
        /// </summary>
        public Computer()
        {
            manufacture = "";
            model = "";
            purposeCode = "";
            CPUCode = "";
        }

        /// <summary>
        /// This is the perameterized contructor that will give the object of the class the values input byu the user or the coder in main in this case 
        /// </summary>
        /// <param name="usrManufacture"> The string the user inputs as the computers manufacuter </param>
        /// <param name="usrModel"> The string the user inputs as the computers model </param>
        /// <param name="usrPurposeCode"> The string the user inputs as the computers purpose code </param>
        /// <param name="usrCPUCode"> The string the user inputs as the computers CPU Code </param>
        public Computer(string usrManufacture, string usrModel, string usrPurposeCode, string usrCPUCode)
        {
            manufacture = usrManufacture;
            model = usrModel;
            purposeCode = usrPurposeCode;
            CPUCode = usrCPUCode;
        }
        /// <summary>
        /// The Write to console function takes the vars specified and prints them to the screen
        /// It will then print it to the screen when ran
        /// </summary>
        public virtual void WriteToConsole()
        {
            WriteLine(
                format: "The Computer: [Manufacture: {0} ; Model: {1} ; Purpose Code: {2} ; CPU Code: {3}]",
                manufacture,
                model,
                purposeCode,
                CPUCode
                );
        }

    }
}
