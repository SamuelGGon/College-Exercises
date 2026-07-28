/*

Given the menu of a snack bar:

Code	Product	     Price
100	     Hot Dog	  $1.20
101	  Simple Bauru	  $1.30
102	  Bauru with Egg  $1.50
103	    Hamburger	  $1.20
104	   Cheeseburger	  $1.30
105	     Soda	      $1.00

Write an algorithm that:
Reads the product code and quantity;
Calculates the total amount to be paid by the customer;
Prints the total amount to be paid;
Prints the product name.

Faça um algoritmo que:
Leia o código do produto e a quantidade;
Calcule o valor a ser pago pelo cliente;
Imprima o valor a ser pago;
Imprima o nome do produto.

*/

using System;

namespace Exercicio32
{
    class Program
    {
        static void Main(string[] args)
        {
            int code, quantity;

            Console.WriteLine(@"
            Given the menu of a snack bar:

            Code 	 Product	  Price
            100	     Hot Dog	  $1.20
            101	  Simple Bauru	  $1.30
            102	  Bauru with Egg  $1.50
            103	    Hamburger	  $1.20
            104	   Cheeseburger	  $1.30
            105	     Soda	      $1.00");
            Console.WriteLine("Which code ?");
            code = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many do you want ?");

            quantity = Convert.ToInt32(Console.ReadLine());

            switch (code)
            {
                case 100:
                    Console.WriteLine($"Your bill will be {1.20 * quantity}");
                    break;

                case 101:
                    Console.WriteLine($"Your bill will be {1.30 * quantity}");
                    break;
                case 102:
                    Console.WriteLine($"Your bill will be {1.50 * quantity}");
                    break;
                case 103:
                    Console.WriteLine($"Your bill will be {1.20 * quantity}");
                    break;
                case 104:
                    Console.WriteLine($"Your bill will be {1.30 * quantity}");
                    break;
                case 105:
                    Console.WriteLine($"Your bill will be {quantity}");
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;

            }
            
        }
    }
}

