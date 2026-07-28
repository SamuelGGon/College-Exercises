/*

The company XSoftware granted a bonus of 20% of the salary value to all employees with a tenure at the company equal to or greater than five years, 
and a 10% bonus to the remaining employees.
Create an algorithm that reads the salary and the number of years of each employee, calculates, and prints the bonus value.

A empresa XSoftware concedeu um bônus de 20% do valor do salário para todos os funcionários com tempo de serviço na empresa igual ou superior a cinco anos,
e um bônus de 10% para os demais funcionários.
Crie um algoritmo que leia o salário e o número de anos de cada funcionário, calcule e imprima o valor do bônus.


*/

using System; 

namespace Exercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            double salary;
            int year;

            Console.WriteLine("How many years do you work on your company: ");
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How much is your salary ?");
            salary = Convert.ToDouble(Console.ReadLine());

            if (year >= 5)
            {
                salary = salary * 1.20;
                Console.WriteLine("You are granted to a rise of 20% on your salary");
                Console.WriteLine($"Your new salary is {salary}");
            }
            else
            {
                salary = salary * 1.10;
                Console.WriteLine("You are granted to a rise of 10% on your salary");
                Console.WriteLine($"Your new salary is {salary}");
               
            }
        }
    }
}