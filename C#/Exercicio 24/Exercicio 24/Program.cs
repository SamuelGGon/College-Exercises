/*

Create an algorithm that receives a swimmer's age and prints their category: according to the rules:
Category:	Age
infantilA	5 - 7 years
infantilB	8 - 10 years
juvenilA	11 - 13 years
juvenilB	14 - 17 years
Senior	18 years or more

Faça um algoritmo que receba a idade de um nadador e imprima a sua categoria seguindo as regras:

*/

using System;

namespace Exercicio24
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;

            Console.WriteLine("How old are you ?");

            age = Convert.ToInt32(Console.ReadLine());

            if (age >= 5 && age <= 7)
            {
                Console.WriteLine("you are on infantil A");
            }
            else if (age >= 8 && age <= 10)
            {
                Console.WriteLine("you are on infantil B");

            }
            else if (age >= 11  && age <= 13)
            {
                Console.WriteLine("you are on juvenil A");

            }
            else if (age >= 14 && age <= 17)
            {
                Console.WriteLine("you are on juvenil B");

            }
            else if (age >= 18)
            {
                Console.WriteLine("you are on Senior");

            }




        }
    }
}
