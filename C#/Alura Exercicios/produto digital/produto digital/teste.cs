using System;

namespace Teste 
{
    class Teste 
    {
        static void Main(string[] args)
        {
            InformacaoTec tec1 = new InformacaoTec(100, "windows");
            LojaDigital prot1 = new LojaDigital("Photo Shop", 1000, tec1);

            prot1.ExibirProcuto();
        }
    }
}