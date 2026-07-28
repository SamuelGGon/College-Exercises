/*
Make a program that calculates the triangle area.

Faça uma programa que calcule a area do triângulo.
*/

using System;

namespace Exercicio7
{
    class Program
    {
        static void Main(String[] args)
        {
            double area, height, width;

            Console.WriteLine("Please enter the width of your triangle: ");

            width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the height: ");

            height = Convert.ToDouble(Console.ReadLine());

            area = width * height;

            Console.WriteLine($"Your area is {area}");

        }
    }
}