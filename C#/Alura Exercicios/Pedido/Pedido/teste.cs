using System;

namespace Teste
{
    class Programa
    {
        static void Main(string[] args)
        {
            Pedido p1 = new Pedido(1, "Cliente1");

            p1.Exibir();

            p1.AtualizarStatus(1);

            p1.Exibir();


        }
    }
}