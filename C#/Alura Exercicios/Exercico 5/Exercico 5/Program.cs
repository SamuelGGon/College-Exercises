/*
 Criar um programa que calcula a soma de todos os elementos inteiros em uma lista.
 */

using System;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int> {23, 4, 37, 10, 8};
            int total = 0;

            for (int c = 0; c < num.Count; c++)
            {
                Console.WriteLine(num[c]);
                total += num[c];

            }
            Console.WriteLine(total);
        }
    }
}