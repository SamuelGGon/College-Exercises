/*
Make a program that read two student's grade and take weighted average, a note has weight of 4 and 6.

Faça um programa que leia duas notas de um estudante e tire a média ponderada, primeira nota vale 4 e a segunda 6
*/


using System;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {

            double note1, note2;

            Console.WriteLine("Please insert the first grade: ");

            note1 =  Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The second grade");

            note2 = Convert.ToDouble(Console.ReadLine());

            

            Console.WriteLine($"Your average is {((note1 * 4) + (note2 * 6)) / (4 + 6)}");



        }
    }
}