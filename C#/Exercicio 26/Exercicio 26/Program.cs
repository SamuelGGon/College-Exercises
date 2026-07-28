/*

Create a basic operations calculator:

addition, subtraction, multiplication, and division.
the algorithm must read two numbers and the symbol corresponding to the desired operation;
use the char type to read the operation;
at the end, the result must be printed.
Restrictions:
if the entered symbol does not correspond to an operation...
display the message Invalid Symbol and terminate.
for the division operation, check if the divisor is valid (greater than zero)!
if it is less than or equal to zero, display the message "Impossible to divide!!".


Crie uma calculadora de operações básicas:

Adição, subtração, multiplicação e divisão.
O algoritmo deve ler dois números e o símbolo correspondente à operação desejada.
Use o tipo char para ler a operação.
No final, o resultado deve ser impresso.
Restrições:
Se o símbolo inserido não corresponder a uma operação válida, exiba a mensagem "Símbolo inválido" e termine o programa.
Para a operação de divisão, verifique se o divisor é válido (maior que zero)!
Se for menor ou igual a zero, exiba a mensagem "Impossível dividir!!".

*/

using System;

namespace Exerciico26
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            char op;

            Console.WriteLine("this is a simply calculator");
            Console.WriteLine("Write the first number:");

            num1 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Write the second number:");

            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What you would like to do ? Write one of the operation [+, -, *, /]");
            op = Convert.ToChar(Console.ReadLine());
            
            if (op == '+')
            {
                Console.WriteLine($"The addition {num1} + {num2} = {num1 + num2}");
            }
            else if (op == '-')
            {
                Console.WriteLine($"The substraction {num1} - {num2} = {num1 - num2}");
            }
            else if (op == '*')
            {
                Console.WriteLine($"The multiplication {num1} * {num2} = {num1 * num2}");
            }
            else
            {
                if (num2 == 0)
                {
                    Console.WriteLine("We can't divide to zero, yet");
                }
                else
                {
                    Console.WriteLine($"The addition {num1} / {num2} = {num1 / num2}");
                }
            }
        }
    }   
}
