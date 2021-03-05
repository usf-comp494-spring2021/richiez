using System;
using RZielinski_HW_04;
namespace RZielinski_HW04_Main
{
    class Program
    {
        static void Main(String[] args)
        {

            Computer test = new Computer();
            Laptop test2 = new Laptop();
            Server test3 = new Server();

            test.manufacture = "Dell";
            test.model = "Alienware";
            test.purposeCode = "1234";
            test.CPUCode = "5678";
            test.WriteToConsole();

            test2.manufacture = "Dell";
            test2.model = "Alienware";
            test2.purposeCode = "1234";
            test2.CPUCode = "5678";
            test2.screenSize = 13;
            test2.WriteToConsole();

            test3.manufacture = "Dell";
            test3.model = "Alienware";
            test3.purposeCode = "1234";
            test3.CPUCode = "5678";
            test3.CPUCount = 3;
            test3.WriteToConsole();

        }
    }
}
