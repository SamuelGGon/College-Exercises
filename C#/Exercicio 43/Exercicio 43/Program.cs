/*

Read an integer number and print on the screen the sequence of numbers from 1 up to the number read.

Ler um número inteiro e imprimir na tela a sequência de números que vai do número 1 até o número lido.

*/

using System;

namespace Exercicio43
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Write a number");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= num; i++)
            {
                Console.WriteLine($"The sequence {num} to {i}");
            }
        }
    }
}