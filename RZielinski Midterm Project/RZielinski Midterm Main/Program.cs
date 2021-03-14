// Author: Richard Zielinski 
// date: 3/13/21
// project: Midterm
// purpose: Reading in a file and updating it with new information (mean and median) 

using System;
using System.IO;
using CalculatorLib;
namespace RZielinski_Midterm_Main
{
    class Program
    {
        static void Main(string[] args)
        {
            // create the array for the file contents to be read into
            double[] myArr = new double[100];
            int size = 0;

            // to store the directory loction, will look for input file here, will output a file here
            string dir = Environment.CurrentDirectory;

            // If the file exists, then the input file will be read in, and an output file will be created
            if (File.Exists(dir + @"\CalcInput.txt"))
            {
                // opening up the input file to be read to
                StreamReader Textfile = new StreamReader(dir + @"\CalcInput.txt");
                string line;

                // will change the strings from the input file to doubles to be fed into the array 
                while ((line = Textfile.ReadLine()) != null)
                {
                    myArr[size] = double.Parse(line);
                    size++;
                }

                // sorting the array for the median later on
                Array.Sort(myArr, 0, size);

                // test to see if the array is filled with the file info by outputting to the console 
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine(myArr[i]);
                }

                // getting the median of the array 
                var calc = new Calculator();
                double median = calc.Median(myArr, size);
                Console.WriteLine(median);

                // getting the mean of the array 
                var calc2 = new Calculator();
                double mean = calc.Mean(myArr, size);
                Console.WriteLine(mean);

                // the output file is created 
                StreamWriter textwriter = File.CreateText(dir + @"\OutputFile.txt");

                // writing to the output file 
                int element = 0;
                for (int i = 0; i < size; i++)
                {

                    textwriter.WriteLine("Array element " + element + " : " + myArr[i] + "\n");
                    element++;
                }
                textwriter.WriteLine("This is its mean: " + mean + "\n");
                textwriter.WriteLine("This is its median: " + median);
                textwriter.Close();
            }
        }
    }
} // end of main
