class FuncionalidadesEstoque
{
    List<Produto>  novoProduto = new List<Produto>();

    public void AdicionarProdutoAoEstoque(Produto produto)
    {
        novoProduto.Add(produto);
    }

    public void ExibirEstoque()
    {
        foreach (var item in novoProduto)
        {
            
            Console.WriteLine(item.ProdutoDescricacaoDetalhada);
           
        }
    }
}