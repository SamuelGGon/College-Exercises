using System;

namespace aluraExercicioClasseProcuto
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto();

            produto1.Nome = "Chuveiro";
            produto1.Marca = "Lorenzeti";
            produto1.Estoque = 1;
            produto1.Preco = 10;

            FuncionalidadesEstoque fun1 = new FuncionalidadesEstoque();
            fun1.AdicionarProdutoAoEstoque(produto1);

            Produto produto2 = new Produto();

            produto2.Nome = "Banana";
            produto2.Marca = "Boa Vida";
            produto2.Estoque = -2;
            produto2.Preco = -20;
            fun1.AdicionarProdutoAoEstoque(produto2);
            
            fun1.ExibirEstoque();

        }
    }
}