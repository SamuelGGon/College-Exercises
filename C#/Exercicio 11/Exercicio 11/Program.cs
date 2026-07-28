/*
Write a program that reads two grades from a student, calculates and displays the student's average grade.

Escreva um programa que lê duas notas de um estudante, calcule e mostre a média desse estudante.

*/


using System;

namespace Exercicio11
{
    class Program
    {
        static void Main(string[] args)
        {

            double grade1, grade2;

            Console.WriteLine("Enter with first grade: ");

            grade1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second grade: ");

            grade2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"You average is {(grade1 + grade2) / 2}");
        }
    }
}