/*

Write a algorithm that prints the sequence from 100 to 200

Escreva um algoritmo que imprima a sequência do numero 100 ao 200


*/

using System;

namespace Exercicio33
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 100;

            while(num <= 200)
            {
                Console.WriteLine(num);
                num += 1;
            }
        }
    }
}