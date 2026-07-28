using System;

namespace Exercicio3
{
    class program
    {
        static void Main(string[] args)
        {
            double gas, dis, avarage;

            Console.WriteLine("The distance in KM that your car run ?");
            dis = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The gas consuption in Liters");
            gas = Convert.ToDouble(Console.ReadLine());

            avarage = dis / gas;

            Console.WriteLine($"Your car run {dis}KM, and consumed {gas:F}L \n The avarage is {avarage}"); 






        }
    }
}
