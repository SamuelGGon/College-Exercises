using System;

namespace aluraExercicioClasseCarro
{
   class Program
    {
        static void Main(string[] args)
        {
            Carro carro1 = new Carro();

            carro1.Marca = "TOYOTA";
            carro1.Modelo = "COROLA XEI";
            carro1.Ano = 1960;

            double ac = carro1.Acelerar = 0.5;

            double teste = carro1.Acelerando(ac, 10);

            Console.WriteLine();

            carro1.Freando(teste, 10);

            carro1.Buzina();

            Console.WriteLine(carro1.DescricaoDetalheda);
        }
    }
}