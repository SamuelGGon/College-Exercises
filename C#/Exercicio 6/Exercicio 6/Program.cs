/*
Ask the user to input the temperature in Celsius and the program output in Fahrenheit

F

Peça ao usuario colocar a temperatura em celcius e o programa da em Fahrenheit
 */


using System;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter celsius tempture: ");
            double celcius = Convert.ToDouble(Console.ReadLine());

            double fahre = (9 * celcius / 5) + 32;

            Console.WriteLine($"the convertion is {fahre}");
        }
    }
}