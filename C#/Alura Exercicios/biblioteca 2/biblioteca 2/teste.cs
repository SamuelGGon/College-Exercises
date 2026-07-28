using System;

namespace teste
{
    class Program
    {
        static void Main (string [] args)
        {
            Livro livro1 = new Livro ();

            livro1.titulo = "Cem dias entre Céu e mar";
            livro1.autor = "Amyr Klink";

            livro1.Exibicao();


        }
    }
}