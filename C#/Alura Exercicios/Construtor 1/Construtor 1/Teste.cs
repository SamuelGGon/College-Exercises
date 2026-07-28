using System;

namespace Teste
{
    class Teste
    {
        static void Main(string[] args)
        {
            Conta conta1 = new Conta(new Titular("Samuel", "0000000", "Rua bobos"), 123, 0, 50, 500);

            Console.WriteLine(conta1.Informacoes);
        }
    }
}