/*

Create an algorithm that verifies the validity of a password provided by the user.
Knowing that the correct password is R10p5:
Print the message "Access granted" or "Access denied"

Crie um algoritmo que verifique a validade de uma senha fornecida pelo usuário.
Sabendo que a senha correta é R10p5:
Exiba a mensagem "Acesso concedido" ou "Acesso negado".

*/

using System;

namespace Exercicio21
{
    class Program
    {
        static void Main(string[] args)
        {
            string password, userPass;
            Console.WriteLine("Please enter with the password");
            password = "R10p5";
            userPass = Console.ReadLine();

            if(userPass == password)
            {
                Console.WriteLine("Access granted");
            }
            else
            {
                Console.WriteLine("Access denied");
            }

        }
    }
}