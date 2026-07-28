using System;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario fun1 = new Funcionario("Marquinhos", "aventureiro");

            Console.WriteLine(fun1.Nome);
            Console.WriteLine(fun1.Cargo);

            fun1.Promover("ze");

            Console.WriteLine(fun1.Nome);
            Console.WriteLine(fun1.Cargo);
        }
    }
}