/*

Create an algorithm that receives the age and height of 10 people:  
– Calculate and display the average height of those over 50 years old.

Faça um algoritmo que receba a idade e a altura de 10 pessoas:
– calcule e mostre a média das alturas daquelas com mais de 50 anos.


*/
using System; 

namespace Exercicio44
{
    class Program
    {
        static void Main(string[] args)
        {
            double average;
            int age, height, people50plus;
            average = people50plus = 0;

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"Write your age [{i}]");
                age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Write your height[CM] [{i}]");
                height = Convert.ToInt32(Console.ReadLine());

                if (age >= 50)
                {
                    people50plus ++;

                    average += height;
                }
                
            }

            Console.WriteLine($"The average's height of people 50 over is {average / people50plus}");
        }
    }
}