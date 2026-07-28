/*

The BMI (Body Mass Index) is a measure of a person's degree of obesity.
Create an algorithm that reads the height and weight of 10 people.
Calculate the BMI of each person and check how many people have a BMI between 18.5 and 24.9, which is considered a normal weight.

O IMC (índice de Massa Corporal) é uma medida do grau de obesidade 	de uma pessoa.
Faça um algoritmo que leia a altura e o peso de 10 pessoas.
Calcular o IMC de cada pessoa e verificar quantas pessoas estão com o IMC entre 18,5 e 24,9 que é considerado sem obesidade.

*/


using System;

namespace Exercicio39
{
    class Program
    {
        static void Main(string[] args)
        {
            double imc, meter, kilo;
            int stop, noObsPlp;

            stop = noObsPlp = 0;

            while(stop < 10)
            {
                Console.WriteLine($"Write down your height in METERs: {stop}");
                meter = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Write down your weight in Kilosgram: {stop}");
                kilo = Convert.ToDouble(Console.ReadLine());

                imc = Math.Round(kilo / (Math.Pow(meter, 2)), 2);
                Console.WriteLine(imc);

                if ( imc >= 18.5 && imc <= 24.9)
                {
                    noObsPlp += 1;
                }
                else
                {
                    Console.WriteLine("Your situation is critic");
                }
                stop += 1;
            }
            Console.WriteLine($"People with no obesity: {noObsPlp}");
        }
    }
}