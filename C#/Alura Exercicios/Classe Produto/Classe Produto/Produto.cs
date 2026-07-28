class Produto
{
    private string nome;
    private string marca;
    private decimal preco;
    private int estoque;

    public string Nome { get => nome; set => nome = value;}

    public string Marca { get => marca; set => marca = value; }
    public decimal Preco 
    {
        get => preco; 
        set
        {
            if (value < 0)
            {

                Console.WriteLine($"O produtudo: {nome}, não pode ter valor negativo:");

            }
            else
            {
                preco = value;
                return;
                
            }
        }
    }

    public int Estoque
    {
        get => estoque;
        set
        {
            if(value < 0)
            {
                Console.WriteLine($"O produtudo: {nome}, não pode colocar zero produtos");
            }
            else
            {
                estoque = value;
                return; 
            }
        } 
    }

    public string ProdutoDescricacaoDetalhada => $"Produto nome: {nome}\nMarca do Produto: {marca}\nPreço: R${preco}\n Quantidade em estoque: {estoque}";

}