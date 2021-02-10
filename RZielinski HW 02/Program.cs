using System;

namespace RZielinski_HW_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // array creation
            int[] myNum = { 3, 4, 7, 9, 11, 13, 14, 16, 18, 21 };

            // loop walks the array to determine if even/odd & displays message
            for (int i = 0; i < myNum.Length; i++)
            {
                if (myNum[i] % 2 == 0)
                    Console.WriteLine(myNum[i] + ": This number is even");
                else
                    Console.WriteLine(myNum[i] + ": This number is odd");
            }
            // to signal the program is over
            Console.WriteLine("This program has ended"); 
        }
    }
}
