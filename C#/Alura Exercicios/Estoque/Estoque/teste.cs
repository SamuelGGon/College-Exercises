using System;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto pt1 = new Produto("Assolam", 50);

            pt1.ExibirEstoque();

            pt1.Retirar(51);

            
        }
    }
}