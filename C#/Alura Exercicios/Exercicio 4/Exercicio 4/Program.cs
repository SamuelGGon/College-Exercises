/*

 Criar uma lista de bandas vazia e adicionar suas bandas prediletas em seguida.
    e
Utilizar a estrutura 'for' para mostrar todas as suas bandas preferidas, listadas na lista do exercício anterior, no console.
 */

using System;

namespace Exercicio4
{

    class Program
    {
        static void Main(string[] args)
        {
            List<string> bandas = new List<string>();
            string banda;
            char decicao;

            while (true)
            {

            Console.WriteLine(@"
                
   ▄████████ ████████▄   ▄█   ▄████████  ▄█   ▄██████▄  ███▄▄▄▄      ▄████████         ▄████████ ███    █▄     ▄████████      ▀█████████▄     ▄████████ ███▄▄▄▄   ████████▄     ▄████████ 
  ███    ███ ███   ▀███ ███  ███    ███ ███  ███    ███ ███▀▀▀██▄   ███    ███        ███    ███ ███    ███   ███    ███        ███    ███   ███    ███ ███▀▀▀██▄ ███   ▀███   ███    ███ 
  ███    ███ ███    ███ ███▌ ███    █▀  ███▌ ███    ███ ███   ███   ███    █▀         ███    █▀  ███    ███   ███    ███        ███    ███   ███    ███ ███   ███ ███    ███   ███    ███ 
  ███    ███ ███    ███ ███▌ ███        ███▌ ███    ███ ███   ███  ▄███▄▄▄            ███        ███    ███   ███    ███       ▄███▄▄▄██▀    ███    ███ ███   ███ ███    ███   ███    ███ 
▀███████████ ███    ███ ███▌ ███        ███▌ ███    ███ ███   ███ ▀▀███▀▀▀          ▀███████████ ███    ███ ▀███████████      ▀▀███▀▀▀██▄  ▀███████████ ███   ███ ███    ███ ▀███████████ 
  ███    ███ ███    ███ ███  ███    █▄  ███  ███    ███ ███   ███   ███    █▄                ███ ███    ███   ███    ███        ███    ██▄   ███    ███ ███   ███ ███    ███   ███    ███ 
  ███    ███ ███   ▄███ ███  ███    ███ ███  ███    ███ ███   ███   ███    ███         ▄█    ███ ███    ███   ███    ███        ███    ███   ███    ███ ███   ███ ███   ▄███   ███    ███ 
  ███    █▀  ████████▀  █▀   ████████▀  █▀    ▀██████▀   ▀█   █▀    ██████████       ▄████████▀  ████████▀    ███    █▀       ▄█████████▀    ███    █▀   ▀█   █▀  ████████▀    ███    █▀  
                                                                                                                                                                                          
");

            banda = Console.ReadLine();
            bandas.Add(banda);

            Console.Write("\n Quer visualizar a lista de bandas [S/N] ?");
            decicao = Convert.ToChar(Console.ReadLine());
            decicao = char.ToUpper(decicao);

            if (decicao == 'S')
            {
                Console.Clear();
                for (int i = 0; i < bandas.Count; i++)
                {
                    Console.WriteLine($"Banda: {bandas[i]}");
                }
                Thread.Sleep(2000);

            }
            else
            {
                Console.WriteLine("Tchauuu");
                    break;
            }
            




        }

        }

    }
    

}
    
        
    
