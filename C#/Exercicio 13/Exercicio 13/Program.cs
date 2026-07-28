/*

Make a algorithm that read interge input by the user and check if is even or odd.

Faça um algoritmo que lê um numero inteiro inserido pelo usuario e verifique se é par ou impar.

*/

using System;

namespace Exercicio13
{
    class Program
    {
        static void Main(string [] args)
        {
            int num;

            Console.WriteLine("Insert a integer number: ");

            num = Convert.ToInt32(Console.ReadLine());

            if(num % 2 == 0)
            {
                Console.WriteLine($"You choose the number ({num}) and is even");

            }
            else
            {
                Console.WriteLine($"Your choose the number ({num}) and is odd");
            }



        }
    }
}
