/*
 * 
 */


using System;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> {0, 1 ,2, 3, 4, 5, 6, 7, 8, 9};

            foreach (int num in list)
            {
                if (num % 2 == 0)
                {
                    Console.Write($"{num}, ");
                }
            }
        }
    }
}

