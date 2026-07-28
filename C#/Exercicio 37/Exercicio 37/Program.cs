/*

Create an algorithm that prints the multiplication table of 5.

Faça um algoritmo que imprima a tabuada do 5.


*/

using System;

namespace Exercicio37
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            do
            {
                Console.WriteLine($"5 x {num} = {num * 5}");
                num++;
            }
            while (num <= 10);
        }
    }
}