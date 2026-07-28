using System;

namespace banco
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta1 = new ContaBancaria("1235-8", 500);

            conta1.detalhes();

            conta1.Depositar(500);

            conta1.detalhes();
        }
    }
}