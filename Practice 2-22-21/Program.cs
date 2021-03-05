using System;
namespace Practice_2_22_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Person bob = new Person();

            bob.Name = "Bob Smith";
            bob.DateOfBirth = new DateTime(1965, 12, 22);

            Console.WriteLine(
                format: "{0} was born on {1:ddd, d MMMM yyyy}",
                arg0: bob.Name,
                arg1: bob.DateOfBirth
            );
        }
    }
}