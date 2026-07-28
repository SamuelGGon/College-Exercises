/*
Escrever uma função que a partir de dois números de ponto flutuante a e b exiba no console 
o resultado de suas quatro operações básicas (adição, subtração, divisão e multiplicação), utilizando interpolação de strings.
 */

using System;

namespace Exercicio3
{
    class Program
    {
        static void OperacoesBasicas(double num1, double num2)
        {

            Console.WriteLine($"A Adição: {num1} + {num2} = {num1 + num2} ");
            Console.WriteLine($"A Subtração: {num2} - {num1} = {num2 - num1}");
            Console.WriteLine($"Divisão: {num1} / {num2} = {num1 / num2}");
            Console.WriteLine($"Multiplicação: {num1} * {num2} = {num1 * num2}");

        }
        static void Main(string[] args)
        {

            OperacoesBasicas(5, 5);

        }
    }
}