using System;

namespace teste 
{
    class Program
    {
        static void Main(string[] args) 
        {
            Consulta cl1 = new Consulta("Samuel", "Andrea", 27, 7);

            cl1.Exibir();

            cl1.MudarData(22, 8);

            cl1.Exibir();
        }
    }
}