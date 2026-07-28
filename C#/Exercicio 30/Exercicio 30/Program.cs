/*

An employee will receive a raise according to their work plan.
Create an algorithm that reads:

The work plan;
Work Plan	Increase (%)
A	          10%
B	          15%
C	          20%

The employee's current salary;
Calculate and print their new salary.

Um funcionário receberá aumento de acordo com seu plano de trabalho.
Faça um algoritmo que leia:
¨ o plano de trabalho;
¨ e o salário atual de um funcionário;
Calcule e imprima o seu novo salário.


*/

using System;

namespace Exercicio30
{
    class Program
    {
        static void Main(string[] args)
        {
            double salary;
            char plan;

            Console.WriteLine("Please enter with your Salary:");
            salary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter with your work plan [A, B or C]");
            plan = Convert.ToChar(Console.ReadLine());

            plan = char.ToUpper(plan);

            switch (plan)
            {
                case 'A':
                    Console.WriteLine($"your salary is {salary} and with the plan A you will recive a bonus of 10%, your new salary is {salary * 1.10}");
                    break;
                case 'B':
                    Console.WriteLine($"your salary is {salary} and with the plan A you will recive a bonus of 15%, your new salary is {salary * 1.15}");
                    break;
                case 'C':
                    Console.WriteLine($"your salary is {salary} and with the plan A you will recive a bonus of 20%, your new salary is {salary * 1.20}");
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;

            }
        }
    }
}