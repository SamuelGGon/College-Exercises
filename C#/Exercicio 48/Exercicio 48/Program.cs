/*
**Read 10 integer values and store them in an array.**  
(a) Create a loop to print the even elements.  
(b) Create a loop to print the odd elements.

Leia 10 valores inteiros e armazene-os em um vetor.
(a) faça um laço para imprimir os elementos pares.
(b) faça um laço para imprimir os elementos ímpares.


*/

using System;

namespace Exercicio48
{
    class Program
    {
        static void Main(string[] args)
        {
            int num; 
            List<int> numList = new List<int>();


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Write a number [{i + 1}]");
                num = Convert.ToInt32(Console.ReadLine());

                numList.Add(num);
                
            }

            Console.WriteLine("The Evens numbers");
            foreach (var item in numList)
            {

                if (item % 2 == 0)
                {
                    Console.Write($"{item}, "); 
                }
            }
            Console.WriteLine();

            Console.WriteLine("The Odds numbers");
            foreach (var item in numList)
            {
                if (item % 2 != 0)
                {
                    Console.Write($"{item}, ");
                }
            }
            Console.WriteLine();







        }
    }
}