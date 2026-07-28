/*

Create an algorithm that receives two numbers;

Executes the operations listed below...

According to the user's choice.

Option	Message
A	    Average of the entered numbers
S	    Difference between the larger and the smaller number
P	    Product of the entered numbers
D	    Division of the first number by the second

Faça um algoritmo que receba dois números;

Execute as operações listadas abaixo...

De acordo com a escolha do usuário.


*/

using System;

namespace Exercicio31
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            char options;

            Console.WriteLine("Write a number:");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Write another number:");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose to Average, Diference, product and division[A, S, P and D]");

            options = Convert.ToChar(Console.ReadLine());

            options = char.ToUpper(options);

            switch(options)
            {
                case 'A':
                    Console.WriteLine($"The Average is {(num1 + num2) / 2}");
                    break;

                case 'S':
                    if (num1 > num2)
                    {
                        Console.WriteLine($"Difference is {num1 - num2}");
                    }
                    else
                    {
                        Console.WriteLine($"Difference is {num2 - num1}");
                    }
                    break;

                case 'P':
                    Console.WriteLine($"Product is {num1 * num2}");
                    break;

                case 'D':
                    Console.WriteLine($"The division is {num1 / num2}");
                    break;

                default:
                    Console.WriteLine("Wrong input");
                    break;

            }

            


        }
    }
}