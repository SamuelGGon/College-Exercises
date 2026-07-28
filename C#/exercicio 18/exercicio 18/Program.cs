/*

Create an algorithm to read an integer number, check if the number is in the range between 50 (inclusive) and 100 (inclusive), 
if it is, print "Belongs to the range", otherwise, print "Does not belong to the range


*/


using System;

namespace Exercicio18
{
    class Porgram
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Write a integer number: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num >= 50 && num <= 100)
            {
                Console.WriteLine($"The number is in range 50 and 100");
            }
            else
            {
                Console.WriteLine("The number is out of range");
            }
        }
    };
}