/*

Write an algorithm that reads 10 integers and says:
How many are even;
And how many are odd.

Faça um algoritmo que leia 10 números inteiros e diga:
quantos são pares;
e quantos são ímpares.

*/

using System;

namespace Exercicio34
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, count, odd, even;
            odd = even = 0;
            count = 1;

            while (count < 11)
            {
                Console.WriteLine($"Write {count} of 10, number");
                num = Convert.ToInt32(Console.ReadLine());
                count++;

                if (num % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }

            }
            Console.WriteLine($"We have {even} evens and {odd} odds");
        }
    }
}

