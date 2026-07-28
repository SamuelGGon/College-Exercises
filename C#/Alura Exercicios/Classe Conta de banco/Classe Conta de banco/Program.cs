using System;

namespace aluraExercicioDeClassPrincipal
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaDebanco conta1 = new ContaDebanco();

            conta1.NumIndicador = 1;
            conta1.Titular = "Samuel";
            conta1.Saldo = 0;
            
            TitularDaConta titularDaConta1 = new TitularDaConta();
            
            titularDaConta1.Agencia = 001;
            titularDaConta1.Conta = 1;
            titularDaConta1.Titular = conta1;
            titularDaConta1.ContaDetalhada();
            

            

        }
    }
}