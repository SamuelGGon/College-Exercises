/*

Create an algorithm that reads an integer between 1 and 12.  
Print the months in full.

Faça um algoritmo que leia um inteiro entre 1 a 12
imprima os meses por extenso

*/

using System;

namespace Exercicio28
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Write a number between");

            num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("Dezember");
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;

            }


        }
    }
}