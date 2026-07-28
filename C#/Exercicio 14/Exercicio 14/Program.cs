/*
Make a algorithm that the user input his age and checks user is on legal age.

Faça um algoritmo que verifique a idade do usuario e fale se ele é maior de idade. 

*/


using System;

namespace Exercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;

            Console.WriteLine("Please write your age: ");

            age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("You are on legal age");
            }
            else
            {
                Console.WriteLine("You are not on legal age");
            }

        }
    }
}