/*
Criar uma lista de linguagens de programação, com as linguagens C#, Java e JavaScript.

e

Exibir o valor "C#" no console, utilizando a lista criada no exercício anterior.

e

Criar um programa que, dado a entrada de dados de um número n inteiro, a partir do teclado, exibir a n-ésima posição de uma lista.
 */




using System;

namespace aluraExercicio2E3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 2
            List<string> listaLanguagemsProgramação = ["C#", "Java", "JavaScripts"];

            //Exercicio 3
            //Console.WriteLine(listaLanguagemsProgramação.IndexOf("C#"));
            //Console.WriteLine(listaLanguagemsProgramação[0]);

            //Exercicio 4

            Console.Write("Por Favor escreva um numero qualquer: ");
            int num =  Convert.ToInt32(Console.ReadLine());

            
            if (num >= 3)
            {
                Console.WriteLine("Passou o numero de itens da lista");
                Console.WriteLine("Coloque outro");
            }
            else
            {

                Console.WriteLine($"O numero {num - 1}, exibe da lista {listaLanguagemsProgramação[num - 1]}");
            }

        }
    }
}