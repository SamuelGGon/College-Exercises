/*

Create an algorithm that receives the age, height, and weight of 10 people, then calculates and displays:  
a) The number of people older than 50 years.  
b) The average height of people aged between 10 and 20 years.  
c) The percentage of people weighing less than 40 kilograms.

Faça um algoritmo que receba a idade, a altura e o peso de 10 pessoas, calcule e mostre:
a) A quantidade de pessoas maiores de 50 anos.
b) A média das alturas das pessoas com idade entre 10 e 20 anos.
c) A porcentagem de pessoas com peso inferior a 40 quilos.


*/

using System;

namespace Exercicio47
{
    class Program
    {
        static void Main(string[] args)
        {
            int age, people10and20, people50, weight40less;
            double height, weight, average;
            people50 = people10and20 = weight40less = 0;
            average = 0;

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Your age ? ");
                age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Your weight ?");
                weight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Your height ?");
                height = Convert.ToDouble(Console.ReadLine());

                if (age > 50)
                {
                    people50++;
                }
                else if (age >= 10 && age <= 20)
                {
                    average += height;
                    people10and20++;
                }
                if (weight < 40)
                {
                    weight40less++;
                }
            }

            Console.WriteLine($"People with 50 plus {people50}");

            if ( people10and20 > 0 )
            {
                Console.WriteLine($"The average height of people aged between 10 and 20 years. {average / people10and20}");
            }
            else
            {
                Console.WriteLine("No people between 10 and 20");
            }

            Console.WriteLine($"The percentage of people weighting less than 40 kilograms. {Convert.ToDouble((weight40less / 10) * 100)}");
        }
    }
}