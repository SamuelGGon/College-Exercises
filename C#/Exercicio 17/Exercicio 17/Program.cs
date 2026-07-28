/*

Read two float numbers and print then, from bigger to smaller. Supose isn't equal.

Leia dois numero flutuantes e mostre em modo descrescente.

*/

using System;

namespace Exercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;

            Console.WriteLine("Write a number: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Write a another number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            if (num1 < num2)
            {
                Console.WriteLine("The number sequence from small to big");
                Console.WriteLine($"{num1}; {num2}");
            }
            else
            {
                Console.WriteLine("The number sequence from small to big");
                Console.WriteLine($"{num2}; {num1}");
            }
        }
    }
}