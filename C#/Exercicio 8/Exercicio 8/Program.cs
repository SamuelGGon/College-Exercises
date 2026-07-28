/*
Make a program that calculete the fabrication and distribution tax on the car's price: Fabrication 15% and distribution 30%

Faça um programa que calcule o imposto de fabricação e distribuição no preço do carro: fabricação 15% e distribuição 30% 
*/

using System;

namespace Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            double carPrice;

            Console.WriteLine("Please enter your car price, to calculate the tax");

            carPrice = Convert.ToDouble(Console.ReadLine());

            carPrice = carPrice * 1.45;

            Console.WriteLine($"The new car price is {carPrice:F2}");

        }
    }
}