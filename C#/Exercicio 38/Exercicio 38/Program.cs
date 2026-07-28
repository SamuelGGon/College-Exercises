/*

Create an algorithm that reads ten positive integers and displays the smallest among them.

Faça um algoritmo que leia dez números inteiros positivos e mostre o menor entre eles.

*/


using System;

namespace Exercicio38
{
    class Program
    {
        static void Main(string[] args)
        {
            int big, small, stop, num;
            big = small = stop = 0;

            while (stop <= 10)
            {

                if(stop == 0)
                {
                    Console.WriteLine($"Write a number {stop}");
                    num = Convert.ToInt32(Console.ReadLine());
                    big = small = num;
                    stop ++;

                }
                else
                {
                    Console.WriteLine($"Write a another number {stop}");
                    num = Convert.ToInt32(Console.ReadLine());

                    if (num > small)
                    {
                        big = num;
                    }
                    else
                    {
                        small = num;
                    }
                    stop ++;

                }
            }
            Console.WriteLine($"the smallest number is {small}");
        }
    }
}