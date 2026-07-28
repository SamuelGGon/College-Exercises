/*
Guess the number game. The number to be guessed is 15, given a number provided by the user, check, got it right;
if the guess is above the number 15 or if it is below 15

Jogo da adivinhação. O numero para adivinhar é 15, o usuário vai escrever um numero, caso for maior, vai imprimir
é maior que  15, caso menor vai imprimir é menor que 15, até ser acertado.

*/


using System;

namespace Exercicio15
{
    class Program
    {
        static void Main(string [] args)
        {
            int num,guess;

            guess = 15;

            Console.WriteLine("Try to guess the number. ");
            Console.WriteLine("Insert a number ");

            num = Convert.ToInt32(Console.ReadLine());

            if(num == guess)
            {
                Console.WriteLine("You guessed the number ");
            }
            else if(num > guess)
            {
                Console.WriteLine("Your guess is higher");
            }
            else if (num < guess)
            {
                Console.WriteLine("Your guess is lower");
            }
            
          
            




        }
    }
}