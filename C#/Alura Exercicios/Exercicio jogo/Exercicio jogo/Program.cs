using System;


namespace aluraExercicioJogo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomCPU = new Random();

            int numChooseByCPU, userNum;

            numChooseByCPU = randomCPU.Next(1, 101);
            Console.WriteLine(@"
                                              ▒▒███                           ▒▒███                                    ▒▒███
      ▒▒███                                   ▒▒███                           ▒▒███  ▒▒▒               ▒▒▒             ▒▒███                
       ▒███   ██████   ███████  ██████      ███████   ██████      ██████    ███████  ████  █████ █████ ████  ████████   ▒███████    ██████  
       ▒███  ███▒▒███ ███▒▒███ ███▒▒███    ███▒▒███  ███▒▒███    ▒▒▒▒▒███  ███▒▒███ ▒▒███ ▒▒███ ▒▒███ ▒▒███ ▒▒███▒▒███  ▒███▒▒███  ▒▒▒▒▒███ 
       ▒███ ▒███ ▒███▒███ ▒███▒███ ▒███   ▒███ ▒███ ▒███████      ███████ ▒███ ▒███  ▒███  ▒███  ▒███  ▒███  ▒███ ▒███  ▒███ ▒███   ███████ 
 ███   ▒███ ▒███ ▒███▒███ ▒███▒███ ▒███   ▒███ ▒███ ▒███▒▒▒      ███▒▒███ ▒███ ▒███  ▒███  ▒▒███ ███   ▒███  ▒███ ▒███  ▒███ ▒███  ███▒▒███ 
▒▒████████  ▒▒██████ ▒▒███████▒▒██████    ▒▒████████▒▒██████    ▒▒████████▒▒████████ █████  ▒▒█████    █████ ████ █████ ████ █████▒▒████████
 ▒▒▒▒▒▒▒▒    ▒▒▒▒▒▒   ▒▒▒▒▒███ ▒▒▒▒▒▒      ▒▒▒▒▒▒▒▒  ▒▒▒▒▒▒      ▒▒▒▒▒▒▒▒  ▒▒▒▒▒▒▒▒ ▒▒▒▒▒    ▒▒▒▒▒    ▒▒▒▒▒ ▒▒▒▒ ▒▒▒▒▒ ▒▒▒▒ ▒▒▒▒▒  ▒▒▒▒▒▒▒▒ 
                      ███ ▒███                                                                                                              
                     ▒▒██████                                                                                                               
                      ▒▒▒▒▒▒                                                                                                                
");
            Console.WriteLine("Vamos jogar !!");
            Console.WriteLine("Tente adivinhar o numero que estou pensando");
            Console.Write("\nEscreva um numero: ");
            userNum = Convert.ToInt32(Console.ReadLine());

            do
            {

                if(userNum > numChooseByCPU)
                {
                    Console.WriteLine($"Você escolheu um numero alto, tente de novo. Seu numero ---> {userNum} <--- ");
                    userNum = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine($"Você escolheu um numero baixo, tente de novo. Seu numero ---> {userNum} <--- ");
                    userNum = Convert.ToInt32(Console.ReadLine());
                }

            } while (userNum != numChooseByCPU);

            Console.WriteLine(@"
             
 ███████████                                █████                                
▒▒███▒▒▒▒▒███                              ▒▒███                                 
 ▒███    ▒███  ██████   ████████   ██████   ▒███████   ██████  ████████    █████ 
 ▒██████████  ▒▒▒▒▒███ ▒▒███▒▒███ ▒▒▒▒▒███  ▒███▒▒███ ███▒▒███▒▒███▒▒███  ███▒▒  
 ▒███▒▒▒▒▒▒    ███████  ▒███ ▒▒▒   ███████  ▒███ ▒███▒███████  ▒███ ▒███ ▒▒█████ 
 ▒███         ███▒▒███  ▒███      ███▒▒███  ▒███ ▒███▒███▒▒▒   ▒███ ▒███  ▒▒▒▒███
 █████       ▒▒████████ █████    ▒▒████████ ████████ ▒▒██████  ████ █████ ██████ 
▒▒▒▒▒         ▒▒▒▒▒▒▒▒ ▒▒▒▒▒      ▒▒▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒   ▒▒▒▒▒▒  ▒▒▒▒ ▒▒▒▒▒ ▒▒▒▒▒▒  
                                                                                 
                                                                                 
                                                                                 
");
            Console.WriteLine($"O numero da CPU foi ---> {numChooseByCPU} <---");


           
        }
    }
}