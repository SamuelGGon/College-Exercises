/* 
Write a program that reads the four values corresponding to two points on the x and y axes in the plane, p1(x1,y1) and p2(x2,y2)
and calculates the distance between them according to the formula: Distance SQRT((x2-x1)²+(y2-y1)²)

Escreva um programa que leia os quatro valores correspondentes a dois pontos nos eixos x e y no plano, p1(x1, y1) e p2(x2, y2),
e calcule a distância entre eles usando a fórmula: Distancia SQRT((x2-x1)²+(y2-y1)²)

*/


using System;

namespace Exercicio12
{
    class Program
    {
        static void Main(string[] args)
        {

            double x1, x2, y1, y2, line;

            Console.WriteLine("Please enter the X of the first point: ");
            x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the Y of the first point: ");

            y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the X of the second point: ");

            x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the Y of the second point: ");

            y2 = Convert.ToDouble(Console.ReadLine());

            line = Math.Sqrt((Math.Pow((x2 - x1), 2)) + (Math.Pow((y2 - y1), 2))) ;

            Console.WriteLine($"The distance betwen two points is {line}");

        }
    }
}
