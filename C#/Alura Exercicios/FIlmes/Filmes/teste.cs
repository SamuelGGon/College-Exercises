using System;

namespace Tetes
{
    class Program
    {
        static void Main(string[] args)
        {
            Filmes fl1 = new Filmes();
            
            fl1.Classificacao = -1;
            fl1.Titulo = "curacao";
            fl1.ClassificacaoEtaria(4);

        }
    }
}