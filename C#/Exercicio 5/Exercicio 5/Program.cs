/*
Build a algorithm that read any integer given as a second / Construa um algoritmo que lê uma quantidade qualquer de segundos 
and convert this values to hour, minutes and  seconds / e converta esse valor em horas, minutos e segundos.
➢ Exemple:
■ input: 12345
■ output: 3 horas 25 minutos e 45 segundos
 */
using System;

namespace Exercicio5
{
    class Program
    {
        public static void Main(string[] args)
        {
            double num;

            Console.WriteLine("Please write any seconds to convert the time in h/m/s");

            num =  Convert.ToDouble( Console.ReadLine());

            Console.WriteLine(Convert.ToInt32( num / 3600));
            Console.WriteLine($"The number {num} is equal to {Convert.ToInt32(num / 3600)} Hours, {(Convert.ToInt32(num % 3600)) / 60} Minutes and {(num % 3600) % 60} seconds");
            Console.WriteLine((num % 3600) % 60);


        }
    }
}
