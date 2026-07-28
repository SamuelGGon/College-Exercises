/*
Criar um programa que gerencie o estoque de uma loja. 
Utilize um dicionário para armazenar produtos e suas quantidades em estoque e mostre, 
a partir do nome de um produto, sua quantidade em estoque.
 */

using System;

namespace aluraExercicio9
{
    class Program
    {
        static void MesagemAdpativa(string titulo)
        {
            int tamanhoTexto = titulo.Length;
            char asterisco = '*';
            string tamanhoCertoDeAsteriscos = "";
           

            for (int numDeAsterisco = 0; numDeAsterisco < tamanhoTexto; numDeAsterisco++)
            {
               tamanhoCertoDeAsteriscos += Convert.ToString(asterisco);
            }

            Console.WriteLine(tamanhoCertoDeAsteriscos);
            Console.WriteLine(titulo);
            Console.WriteLine(tamanhoCertoDeAsteriscos);


        }

        static void Main(string[] args)
        {
            Dictionary<string, int> produto = new Dictionary<string, int>();
            produto.Add("banana", 2);
            produto.Add("a  çúcar", 5);
           
            void MostrarEstoque(string nomeProduto)
            {
                
                if (produto.ContainsKey(nomeProduto))
                {
                    Console.WriteLine($"Produto: {nomeProduto} contem: {produto[nomeProduto]}");
                }
                else
                {
                    Console.WriteLine("Produto não estocado");
                }

            }
            void AdicionandoEmEstoque(string produtoNome, int quantidade)
            {

                produto.Add(produtoNome, quantidade);

            }

            void MenuPrincipal()
            {
                Console.WriteLine(@"

    ███████╗███████╗████████╗ ██████╗  ██████╗ ██╗   ██╗███████╗    ██████╗  █████╗     ██╗      ██████╗      ██╗ █████╗ 
    ██╔════╝██╔════╝╚══██╔══╝██╔═══██╗██╔═══██╗██║   ██║██╔════╝    ██╔══██╗██╔══██╗    ██║     ██╔═══██╗     ██║██╔══██╗
    █████╗  ███████╗   ██║   ██║   ██║██║   ██║██║   ██║█████╗      ██║  ██║███████║    ██║     ██║   ██║     ██║███████║
    ██╔══╝  ╚════██║   ██║   ██║   ██║██║▄▄ ██║██║   ██║██╔══╝      ██║  ██║██╔══██║    ██║     ██║   ██║██   ██║██╔══██║
    ███████╗███████║   ██║   ╚██████╔╝╚██████╔╝╚██████╔╝███████╗    ██████╔╝██║  ██║    ███████╗╚██████╔╝╚█████╔╝██║  ██║
    ╚══════╝╚══════╝   ╚═╝    ╚═════╝  ╚══▀▀═╝  ╚═════╝ ╚══════╝    ╚═════╝ ╚═╝  ╚═╝    ╚══════╝ ╚═════╝  ╚════╝ ╚═╝  ╚═╝
                                                                                                                         ");

                Console.WriteLine("1. Para adicionar produto ao estoque");
                Console.WriteLine("2. Consultar Produto \n");

            }
            while (true)
            {

                MenuPrincipal();

                int escolhaUser = 0;
                escolhaUser = Convert.ToInt32(Console.ReadLine());

                switch (escolhaUser)
                {
                    case 1:
                        Console.Clear();
                        MesagemAdpativa("Adicionando Produto");
                        Console.Write("\n Qual o nome do produto? ");
                        string nomeProdutoSerAdd = Console.ReadLine()!;
                        Console.Write($"\nQuantos ? ");
                        int quantidade = Convert.ToInt32(Console.ReadLine());
                        if(quantidade <= 0)
                        {
                            Console.WriteLine("Não pode adicionar zero");
                         
                        }
                        else
                        {
                            AdicionandoEmEstoque(nomeProdutoSerAdd, quantidade);
                            Thread.Sleep(2000);
                            Console.Clear();
                        }
                    
                        break;

                    case 2:
                        Console.Clear();
                        MesagemAdpativa("Procura de Produto");
                        Console.Write("Qual produto ? ");
                        string produtoSendoProcurado = Console.ReadLine()!.ToLower();
                        MostrarEstoque(produtoSendoProcurado);
                        Thread.Sleep(2000);
                        Console.Clear();
                    
                        break;
                    default:
                        Console.WriteLine("Opção invalida");
                        break;


                }
            }

            
        }
    }
}