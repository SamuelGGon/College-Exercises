/*

Create an algorithm that reads a number from 1 to 7.
Print the corresponding day of the week;
Assume that 1 corresponds to Sunday.

Crie um algoritmo que leia um número de 1 a 7.
imprima o dia da semana correspondente;
assuma que 1 corresponde ao Domingo

*/



using System;

namespace Exercicio27
{
    class Program
    {
        static void Main(string[] args)
        {
            int day;
            Console.WriteLine("Write a number from 1 to 7");

            day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tueday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thrusday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("That number is not available");
                    break;
            }

        }
    }
}