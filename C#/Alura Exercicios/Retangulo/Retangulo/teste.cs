using System;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo rt1 = new Retangulo();

            rt1.Altura = 5;
            rt1.Largura = 4;

            double cal = rt1.CalcularArea();

            Console.WriteLine(cal);
        }
    }
}