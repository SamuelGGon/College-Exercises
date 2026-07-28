using System;

namespace Bissecao
{
    class Bissecao
    {
        //ax^10 + b = 0
        public static void Main(string[] args)
        {

            string funcao;

            Console.Write("Escreva a sua função: ");

            funcao = Console.ReadLine()!;

            //Console.WriteLine(funcao);

            for(int i = 0; i < funcao.Length; i += 1)
            {

                if (funcao[i] == '^')
                {
                    Console.WriteLine(Math.Pow(Convert.ToDouble(funcao[i - 1].ToString()), Convert.ToDouble(funcao[i + 1].ToString())));

                    
                }
            }

        }
    }
}