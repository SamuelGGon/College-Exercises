/*
Make a algorithm that reads a integer number
if the number is bigger than 20, calcule and print half of it.

Faça um algoritimo que lei um numero inteiro
se o numero for maior que 20, calcule e imprima a metade dele.

*/

using System;

namespace Exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Please insite a number");
            
            num = Convert.ToInt32(Console.ReadLine());

            if (num > 20)
            {
                Console.WriteLine($"The half of {num} is {num / 2}");
            }
            else
            {
                Console.WriteLine("You choose a number less then 20");
            }

        }
    }
}