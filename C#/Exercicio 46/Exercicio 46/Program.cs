/*

In a presidential election, there are four candidates.  
Votes are recorded using a code:  
- **1, 2, 3, or 4** - Vote for the respective candidate  
- **5** - Null vote  
- **6** - Blank vote  
Create an algorithm that reads the votes of 10 voters.  
Calculate and display:  
- **a)** The total number of votes for each candidate  
- **b)** The total number of null votes  
- **c)** The total number of blank votes  
- **d\n)** The percentage of blank and null votes


Em uma eleição presidencial, existem quatro candidatos.
Os votos são informados através de um código:
¨ 1, 2, 3 ou 4 - Voto para o respectivo candidato
¨ 5 - Voto nulo
¨ 6 - Voto em branco
Faça um algoritmo que leia o voto de 10 eleitores.
Calcule e mostre:
¨ a) O total de votos para cada candidato;
¨ b) O total de votos nulos;
¨ c) O total de votos em branco;
¨ d\n) O percentual dos votos brancos e nulos.



*/

using System;

namespace Exercicio46
{
    class Program
    {
        static void Main(string[] args)
        {
            int can1, can2, can3, can4, nulls, writes, choose;

            can1 = can2 = can3 = can4 = nulls = writes = 0;

            Console.WriteLine("Elections cadidates 1, 2, 3 and 4. 5 to null and 6 Write");

            for (int i = 0; i < 10 ; i++)
            {
                Console.WriteLine("Who do you like to vote");
                choose = Convert.ToInt32(Console.ReadLine());
                
                switch (choose)
                {
                    case 1:
                        can1++;
                        break;
                    case 2:
                        can2++;
                        break;
                    case 3:
                        can3++;
                        break;
                    case 4:
                        can4++;
                        break;
                    case 5:
                        nulls++;
                        break;
                    case 6:
                        writes++;
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;

                }
                

            }
            Console.WriteLine($"The candidate  1 has {can1} votes ");
            Console.WriteLine($"The candidate  2 has {can2} votes ");
            Console.WriteLine($"The candidate  3 has {can3} votes ");
            Console.WriteLine($"The candidate  4 has {can4} votes ");
            Console.WriteLine($"The Nulls  has {nulls} votes ");
            Console.WriteLine($"The White  has {writes} votes ");
            Console.WriteLine($"The percetual is {((nulls + writes) / 10) * 100}%");

        }
    }
}