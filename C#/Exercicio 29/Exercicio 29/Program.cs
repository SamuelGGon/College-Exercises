/*

Create an algorithm that reads the period in which a student studies:  
M - Morning;  
V - Afternoon;  
N - Night.

Faça um algoritmo que leia o período em que um aluno estuda:


*/

using System;

namespace Exercicio29
{
    class Program
    {
        static void Main(string[] args)
        {
            char day;

            Console.WriteLine("Which period do you study ?");
            Console.WriteLine("Morning[M], Afternoon[V] or Night[N]");

            day = Convert.ToChar(Console.ReadLine());
            day = char.ToUpper(day);

            switch (day)
            {
                case 'M':
                    Console.WriteLine("Good Morning");
                    break;

                case 'V':
                    Console.WriteLine("Good afternoon");
                    break;

                case 'N':
                    Console.WriteLine("Good evening");
                    break;

                default:
                    Console.WriteLine("Wrong input");
                    break;
            }



        }
    }
}