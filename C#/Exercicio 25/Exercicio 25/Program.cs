/*

Read a person's salary and calculate and print  from the INSS ewSalary (calculated!!) according to  table below:

Salary Range            from the INSS iscount
≤ R$ 600.00	                   Exempt
> R$ 600.00 and ≤ R$ 1200.00	20%
> R$ 1200.00 and ≤ R$ 2000.00	25%
> R$ 2000.00	                30%

Ler o salário de uma pessoa e calcular e imprimir o desconto do from the INSS calculado!!) de acordo com a tabela a seguir

*/

using System;

namespace Exercicio25
{
    class Program
    {
        static void Main(string[] args)
        {
            double salary;

            Console.WriteLine("Write your salary");

            salary = Convert.ToDouble(Console.ReadLine());

            if (salary <= 600)
            {
                Console.WriteLine("Exempt");
            }
            else if(salary > 600 && salary <= 1200)
            {
                Console.WriteLine($"the INSS wil discount from your salary {salary = salary * .2}");
            }
            else if (salary > 1200 && salary <= 2000)
            {
                Console.WriteLine($"the INSS wil discount from your salary {salary = salary * .25}");
            }
            else if (salary > 2000)
            {
                Console.WriteLine($"the INSS wil discount from your salary {salary = salary * .3}");
            }


        }
    }
}
