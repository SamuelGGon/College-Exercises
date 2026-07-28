/*

Create an algorithm that prints half of each number from 10 to 20.

Faça um algoritmo que imprima metade de cada numero de 10 a 20.

*/

using System;

namespace Exercicio36
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;

            num = 10;

            while (num <= 20)
            {
                Console.WriteLine($"The half of each number is {num / 2}");
                num++;
            }
        }
    }
}