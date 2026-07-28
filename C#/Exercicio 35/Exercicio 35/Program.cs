/*

Construct an algorithm that reads an integer and prints the sequence:  
- 1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024...  
- while the sequence value is less than or equal to the read number.

Construir um algoritmo que leia um número inteiro e imprime a sequência:
– 1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024. . .
– enquanto o valor da sequência for menor ou igual ao número lido.



*/

using System;

namespace Exercicio35
{
    class Program
    {
        static void Main(string[] args)
        {
            int stopPoint, pow;

            pow = 1;
            

            Console.WriteLine("Write a number");
            stopPoint = Convert.ToInt32(Console.ReadLine());

          

            while (pow <= stopPoint)
            {
                
                Console.WriteLine(pow);                
                pow *= 2;

            }


        }
    }
}