/*
Make a program that read two integers values from the user keyboard input and print de follow results
adding
subtration
interger division
fraction division
remainder division
*/


using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            double dnum1, dnum2;

            Console.WriteLine("Write a number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write another number");
            num2 = Convert.ToInt32(Console.ReadLine());

            dnum1 = num1;
            dnum2 = num2;

            Console.WriteLine($"The sums {num1} + {num2} = {num1 + num2}");
            Console.WriteLine($"the substration {num1} - {num2} = {num1 - num2}");
            Console.WriteLine($"the integer division {num1} / {num2} = {num1 / num2}");
            Console.WriteLine($"the fraction division {dnum1:F2}  / {dnum2:F2} = {(dnum1 / dnum2):F2}");
            Console.WriteLine($"the remainder division {num1} % {num2} = {num1 % num2}");

        }

    }
}