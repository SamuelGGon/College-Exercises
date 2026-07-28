/*

Make a program that print the sequence
100, 99, 98 .... 1

Faça um programa que imprima a seguinte sequência:
– 100, 99, 98, . . . 1.

*/

using System;

namespace Exercicio41
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}