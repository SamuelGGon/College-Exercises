/*

The City of Rio de Janeiro has opened a credit line for statutory employees.
The maximum installment amount cannot exceed 30% of the gross salary.
Create an algorithm that reads the gross salary and the installment amount and informs whether the loan can be granted or not.
Example:
Gross salary: 1200.00
Installment amount: 400.00
Loan cannot be granted!

*/
using System;

namespace Exercicio22
{
    class Program
    {
        static void Main(string[] args)
        {
            double salary, loan;

            Console.WriteLine("Please enter your salary");
            salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please how much you want to load ?");
            loan = Convert.ToDouble(Console.ReadLine());

            if (loan > (salary * 0.30))
            {
                Console.WriteLine("Loan cannot be granted!");
            }
            else
            {
                Console.WriteLine("Loan granted!");
            }
        }
    }
}