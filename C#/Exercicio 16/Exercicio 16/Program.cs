/* 
Read two intergers number, if is equal number print "Equal", if not, show the bigger and the smaller.

Leia dois numeros inteiros, se é igual mostre "Igual", se não, mostre o maior e o menor.


*/

using System;

namespace Exercicio16
{
    class Program
    {


        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Write a number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Write another number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine($"The numbers input is equal ");
            }
            else if(num1 > num2)
            {
                Console.WriteLine($"The number {num1} is bigger then {num2}");
            }
            else
            {
                Console.WriteLine($"The number {num2} is bigger then {num1}");
            }
        }
    }
}