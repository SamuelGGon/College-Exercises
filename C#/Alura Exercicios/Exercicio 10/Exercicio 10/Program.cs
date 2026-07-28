/*
 Crie um programa que implemente um quiz simples de perguntas e respostas. 
Utilize um dicionário para armazenar as perguntas e as respostas corretas.
 */

using System;

namespace aluraExercicio10
{
    class Program
    {

        static void PrintColoredHeader(List<string>? strColors)
        {
            if (strColors is null || strColors.Count != 8)
            {
                strColors = [];
                for (var i = 0; i < 8; i++)
                {
                    strColors.Add("white");
                }
            }

            var colors = strColors
                .Select(c => c switch
                {
                    "black" => 30,
                    "red" => 31,
                    "green" => 32,
                    "yellow" => 33,
                    "blue" => 34,
                    "magenta" => 35,
                    "cyan" => 36,
                    "white" => 37,
                    _ => 37
                })
                .ToList();

            Console.WriteLine(
                $"\x1b[{colors[0]}m              \x1b[0m\x1b[{colors[1]}m      ___     \x1b[0m\x1b[{colors[2]}m      ___     \x1b[0m\x1b[{colors[3]}m      ___     \x1b[0m\x1b[{colors[4]}m      ___   \x1b[0m\x1b[{colors[5]}m      ___     \x1b[0m\x1b[{colors[6]}m      ___     \x1b[0m\x1b[{colors[7]}m     _____    \x1b[0m\n" +
                $"\x1b[{colors[0]}m     _____    \x1b[0m\x1b[{colors[1]}m     /__/\\    \x1b[0m\x1b[{colors[2]}m     /  /\\    \x1b[0m\x1b[{colors[3]}m     /  /\\    \x1b[0m\x1b[{colors[4]}m     /  /\\  \x1b[0m\x1b[{colors[5]}m     /  /\\    \x1b[0m\x1b[{colors[6]}m     /  /\\    \x1b[0m\x1b[{colors[7]}m    /  /::\\   \x1b[0m\n" +
                $"\x1b[{colors[0]}m    /  /::\\   \x1b[0m\x1b[{colors[1]}m     \\  \\:\\   \x1b[0m\x1b[{colors[2]}m    /  /::|   \x1b[0m\x1b[{colors[3]}m    /  /::|   \x1b[0m\x1b[{colors[4]}m    /  /:/_ \x1b[0m\x1b[{colors[5]}m    /  /:/_   \x1b[0m\x1b[{colors[6]}m    /  /:/_   \x1b[0m\x1b[{colors[7]}m   /  /:/\\:\\  \x1b[0m\n" +
                $"\x1b[{colors[0]}m   /  /:/\\:\\  \x1b[0m\x1b[{colors[1]}m      \\  \\:\\  \x1b[0m\x1b[{colors[2]}m   /  /:/:|   \x1b[0m\x1b[{colors[3]}m   /  /:/:|   \x1b[0m\x1b[{colors[4]}m   /  /:/ /\\\x1b[0m\x1b[{colors[5]}m   /  /:/ /\\  \x1b[0m\x1b[{colors[6]}m   /  /:/ /\\  \x1b[0m\x1b[{colors[7]}m  /  /:/  \\:\\ \x1b[0m\n" +
                $"\x1b[{colors[0]}m  /  /:/~/::\\ \x1b[0m\x1b[{colors[1]}m  ___  \\  \\:\\ \x1b[0m\x1b[{colors[2]}m  /  /:/|:|__ \x1b[0m\x1b[{colors[3]}m  /  /:/|:|__ \x1b[0m\x1b[{colors[4]}m  /  /:/ /:/\x1b[0m\x1b[{colors[5]}m  /  /:/ /:/_ \x1b[0m\x1b[{colors[6]}m  /  /:/ /:/_ \x1b[0m\x1b[{colors[7]}m /__/:/ \\__\\:|\x1b[0m\n" +
                $"\x1b[{colors[0]}m /__/:/ /:/\\:|\x1b[0m\x1b[{colors[1]}m /__/\\  \\__\\:\\\x1b[0m\x1b[{colors[2]}m /__/:/ |:| /\\\x1b[0m\x1b[{colors[3]}m /__/:/ |:| /\\\x1b[0m\x1b[{colors[4]}m /__/:/ /:/ \x1b[0m\x1b[{colors[5]}m /__/:/ /:/ /\\\x1b[0m\x1b[{colors[6]}m /__/:/ /:/ /\\\x1b[0m\x1b[{colors[7]}m \\  \\:\\ /  /:/\x1b[0m\n" +
                $"\x1b[{colors[0]}m \\  \\:\\/:/~/:/\x1b[0m\x1b[{colors[1]}m \\  \\:\\ /  /:/\x1b[0m\x1b[{colors[2]}m \\__\\/  |:|/:/\x1b[0m\x1b[{colors[3]}m \\__\\/  |:|/:/\x1b[0m\x1b[{colors[4]}m \\  \\:\\/:/  \x1b[0m\x1b[{colors[5]}m \\  \\:\\/:/ /:/\x1b[0m\x1b[{colors[6]}m \\  \\:\\/:/ /:/\x1b[0m\x1b[{colors[7]}m  \\  \\:\\  /:/ \x1b[0m\n" +
                $"\x1b[{colors[0]}m  \\  \\::/ /:/ \x1b[0m\x1b[{colors[1]}m  \\  \\:\\  /:/ \x1b[0m\x1b[{colors[2]}m     |  |:/:/ \x1b[0m\x1b[{colors[3]}m     |  |:/:/ \x1b[0m\x1b[{colors[4]}m  \\  \\::/   \x1b[0m\x1b[{colors[5]}m  \\  \\::/ /:/ \x1b[0m\x1b[{colors[6]}m  \\  \\::/ /:/ \x1b[0m\x1b[{colors[7]}m   \\  \\:\\/:/  \x1b[0m\n" +
                $"\x1b[{colors[0]}m   \\  \\:\\/:/  \x1b[0m\x1b[{colors[1]}m   \\  \\:\\/:/  \x1b[0m\x1b[{colors[2]}m     |  |::/  \x1b[0m\x1b[{colors[3]}m     |  |::/  \x1b[0m\x1b[{colors[4]}m   \\  \\:\\   \x1b[0m\x1b[{colors[5]}m   \\  \\:\\/:/  \x1b[0m\x1b[{colors[6]}m   \\  \\:\\/:/  \x1b[0m\x1b[{colors[7]}m    \\  \\::/   \x1b[0m\n" +
                $"\x1b[{colors[0]}m    \\  \\::/   \x1b[0m\x1b[{colors[1]}m    \\  \\::/   \x1b[0m\x1b[{colors[2]}m     |  |:/   \x1b[0m\x1b[{colors[3]}m     |  |:/   \x1b[0m\x1b[{colors[4]}m    \\  \\:\\  \x1b[0m\x1b[{colors[5]}m    \\  \\::/   \x1b[0m\x1b[{colors[6]}m    \\  \\::/   \x1b[0m\x1b[{colors[7]}m     \\__\\/    \x1b[0m\n" +
                $"\x1b[{colors[0]}m     \\__\\/    \x1b[0m\x1b[{colors[1]}m     \\__\\/    \x1b[0m\x1b[{colors[2]}m     |__|/    \x1b[0m\x1b[{colors[3]}m     |__|/    \x1b[0m\x1b[{colors[4]}m     \\__\\/  \x1b[0m\x1b[{colors[5]}m     \\__\\/    \x1b[0m\x1b[{colors[6]}m     \\__\\/    \x1b[0m\x1b[{colors[7]}m              \x1b[0m\n"
            );
        }

        static void PrintColoredHeaderWithSingleColor(string color)
        {
            var colors = new List<string>();
            for (var i = 0; i < 8; i++)
            {
                colors.Add(color);
            }

            PrintColoredHeader(colors);
        }


        static void Main(string[] args)
        {



            int pontos, erros, parada;
            string respostaRepetido = ""; 
            pontos = erros = parada = 0;

            Dictionary<string, Dictionary<int, List<String>>> perguntas = new Dictionary<string, Dictionary<int, List<string>>>
            {
                {"Qual a capital do Brasil?", new Dictionary<int, List<string>> {{2, new List<string> { "São Paulo", "Rio de Janeiro", "Brasília", "Salvador" }}}},
                {"Quantos dias tem um ano bissexto?", new Dictionary<int, List<string>> {{2, new List<string> {"364", "365", "366", "367"}}}},
                {"Qual planeta é conhecido como Planeta Vermelho?",new Dictionary<int, List<string>> {{1, new List<string>{"Júpiter", "Marte", "Vênus", "Saturno"}}}},
                {"Quem escreveu o livro Dom Casmurro?", new Dictionary<int, List<string>> {{1, new List<string> { "José de Alencar", "Machado de Assis", "Clarice Lispector", "Graciliano Ramos"}}}},
                {"Qual é o maior oceano do planeta?", new Dictionary<int, List<string>> {{3, new List<string>{"Atlântico", "Índico", "Ártico", "Pacífico"}}}},
                {"Em matemática, o valor de √144 é:", new Dictionary<int, List<string>> {{2, new List<string>{"10", "11", "12", "14"}}}},
                {"Em que ano ocorreu a Proclamação da República no Brasil?", new Dictionary<int, List<string>> {{2, new List<string> { "1822", "1888", "1889", "1891" }}}},
                {"Qual destas partículas subatômicas NÃO possui carga elétrica?",new Dictionary<int, List<string>> {{2, new List<string>{"Próton", "Elétron", "Nêutron", "Íon"}}}},
                {"Qual é a unidade de medida da corrente elétrica no SI?", new Dictionary<int, List<string>> {{3, new List<string>{"Volt", "Watt", "Ohm", "Ampere" }}}},
                {"Qual princípio afirma que é impossível determinar simultaneamente, com precisão absoluta, a posição e o momento de uma partícula?", new Dictionary<int, List<string>> {{2, new List<string> { "Princípio da Inércia", "Princípio da Conservação de Energia", "Princípio da Incerteza de Heisenberg", "Princípio da Relatividade Geral" }}}}


            };

            PrintColoredHeader(["red", "green", "yellow", "blue", "red", "green", "yellow", "blue"]);

            foreach (string enunciado in perguntas.Keys)
            {
                Console.WriteLine($"\n{enunciado}\n");
                                
                foreach (int resposta in perguntas[enunciado].Keys)
                {
                    List<string> randPerguntas = new List<string>();
                    Random rand = new Random();
                    int randoNum = rand.Next(0, 4);

                    while(parada < perguntas[enunciado][resposta].Count)
                    {

                        

                        if(parada == 0)
                        {
                            randPerguntas.Add(perguntas[enunciado][resposta][randoNum]);
                            Console.WriteLine($"{randoNum}: {perguntas[enunciado][resposta][randoNum]}");
                            parada += 1;

                        }
                        else
                        {

                            if (randPerguntas.Contains(perguntas[enunciado][resposta][randoNum]))
                            {
                                randoNum = rand.Next(0, 4);

                            }
                            else
                            {
                                randPerguntas.Add(perguntas[enunciado][resposta][randoNum]);
                                Console.WriteLine($"{randoNum}: {perguntas[enunciado][resposta][randoNum]}");
                                parada += 1;

                            }
                            
                        }

                    }

                    randPerguntas.Clear();
                    parada = 0;
                    Console.Write("\nQual é a resposta: ");
                    int respostaUser = Convert.ToInt32(Console.ReadLine());
                    if (respostaUser == resposta)
                    {
                        pontos += 10;
                    }
                    else
                    {
                        erros += 1;
                    }
                }
            }
                Console.Clear();
            Console.Write(@"
      ___         ___           ___                       ___           ___           ___           ___           ___     
     /  /\       /  /\         /__/\          ___        /__/\         /  /\         /  /\         /  /\         /  /\    
    /  /::\     /  /::\        \  \:\        /  /\       \  \:\       /  /::\       /  /:/        /  /::\       /  /::\   
   /  /:/\:\   /  /:/\:\        \  \:\      /  /:/        \  \:\     /  /:/\:\     /  /:/        /  /:/\:\     /  /:/\:\  
  /  /:/~/:/  /  /:/  \:\   _____\__\:\    /  /:/     ___  \  \:\   /  /:/~/::\   /  /:/  ___   /  /:/~/::\   /  /:/  \:\ 
 /__/:/ /:/  /__/:/ \__\:\ /__/::::::::\  /  /::\    /__/\  \__\:\ /__/:/ /:/\:\ /__/:/  /  /\ /__/:/ /:/\:\ /__/:/ \__\:\
 \  \:\/:/   \  \:\ /  /:/ \  \:\~~\~~\/ /__/:/\:\   \  \:\ /  /:/ \  \:\/:/__\/ \  \:\ /  /:/ \  \:\/:/__\/ \  \:\ /  /:/
  \  \::/     \  \:\  /:/   \  \:\  ~~~  \__\/  \:\   \  \:\  /:/   \  \::/       \  \:\  /:/   \  \::/       \  \:\  /:/ 
   \  \:\      \  \:\/:/     \  \:\           \  \:\   \  \:\/:/     \  \:\        \  \:\/:/     \  \:\        \  \:\/:/  
    \  \:\      \  \::/       \  \:\           \__\/    \  \::/       \  \:\        \  \::/       \  \:\        \  \::/   
     \__\/       \__\/         \__\/                     \__\/         \__\/         \__\/         \__\/         \__\/    


");
                Console.WriteLine($"Você obteve {pontos} Pontos, e errou {erros}");
                Console.WriteLine($"Você teve {((10d - erros) / 10d) * 100d}% de acertos");
                Console.WriteLine("Aperte qualquer tecla para sair");
                Console.ReadKey();    

        }
    }                   
}