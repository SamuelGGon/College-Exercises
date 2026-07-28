// Criar um dicionário que represente um aluno, com uma lista de notas, e mostre a média de suas notas na tela.

using System;

namespace AluraExercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> alunosNotas = new Dictionary<string, List<double>>();

            alunosNotas.Add("Carolina", new List<double> {1, 2, 3, 4});
            alunosNotas.Add("Ricardo", new List<double> { 2, 5, 6 });

            



            foreach(string alunos in alunosNotas.Keys)
            {

                double somaDeNotas = 0;
                int totalDeNotas = 0;

                foreach (double notas in alunosNotas[alunos])
                {
                    somaDeNotas += notas;
                    totalDeNotas ++;
                    
                }

                Console.WriteLine($"O Aluno: {alunos}, tem a media de {(somaDeNotas / totalDeNotas):F1}");
            }
            

               

            

        }
    }
}