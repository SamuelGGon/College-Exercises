/*
Create an algorithm to find the largest number among three integers.
The algorithm should:
Read three integers;
If they are all equal, print: "The numbers are equal";
Otherwise, print the largest of the three numbers.


Faça um algoritmo para encontrar o maior número entre 3 números inteiros.
O algoritmo deve ler três inteiros;
se forem todos iguais, imprimir: “os números são iguais”;
caso contrário, imprimir o maior dos 3 números.

*/

using System;

namespace Exercicio23
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3, big;

            Console.WriteLine("Please enter the first number:");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the second number:");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the third number:");
            num3 = Convert.ToDouble(Console.ReadLine());



            if (num1 > num2 && num1 > num3)
            {
                big = num1;
                Console.WriteLine($"The bigest input number is {big}");

            }
            else if (num2 > num1 && num2 > num3)
            {
                big = num2;
                Console.WriteLine($"The bigest input number is {big}");
            }
            else if (num3 > num1 && num3 > num2)
            {
                big = num3;
                Console.WriteLine($"The bigest input number is {big}");
            }
            else
            {
                Console.WriteLine("They are all equals");
            }




        }
    }
}