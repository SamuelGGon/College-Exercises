//Pegar a média dos carros vendidos

using System;

namespace aluraExercicio12
{
    class Progam
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> vendasCarros = new Dictionary<string, List<int>> 
            {
                { "Bugatti Veyron", new List<int> { 10, 15, 12, 8, 5 } },
                { "Koenigsegg Agera RS", new List<int> { 2, 3, 5, 6, 7 } },
                { "Lamborghini Aventador", new List<int> { 20, 18, 22, 24, 16 } },
                { "Pagani Huayra", new List<int> { 4, 5, 6, 5, 4 } },
                { "Ferrari LaFerrari", new List<int> { 7, 6, 5, 8, 10 } }
            };

            foreach(string carros in vendasCarros.Keys)
            {
                double soma, totalDeVendas;
                soma = totalDeVendas = 0;
                double media;
                
                foreach(int vendas in vendasCarros[carros])
                {
                    totalDeVendas += vendas;
                    soma += 1;

                }

                media = totalDeVendas / soma; 
                Console.WriteLine($"O Carros {carros}, teve ume media de venda  {media}; ");

            }
        }
    }
}