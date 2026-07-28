using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 28;
            double height = 1.7024;
            string status = "Online";

            Console.WriteLine("Your age is: " + age);
            Console.WriteLine($"Your height is: {height:F2}");
            Console.WriteLine("Your class room status is: " + status);


        }
    }
}