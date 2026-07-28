/*

Create an algorithm that reads a person's height and gender, calculates, and displays their ideal weight.


Faça um algoritmo que leia a altura e o sexo de uma pessoa: calcule e mostre seu peso ideal.

imc = weight / height²

24, 22

*/

using System;

namespace Exercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            char sex;
            double height, weight;

            Console.WriteLine("Please write your height");
            height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Which is your sex [F/M]");
            sex = Convert.ToChar(Console.ReadLine());
            sex = char.ToUpper(sex);

            if (sex == 'M')
            {
                weight = 24 * Math.Pow(height, 2);
                Console.WriteLine($"Your ideal weight is {weight}");
            }
            else
            {
                weight = 22 * Math.Pow(height, 2);
                Console.WriteLine($"Your ideal weight is {weight}");
            }
            




        }
    }
}