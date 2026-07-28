class Jogo
{

    public Jogo(string nome, string genero, double preco)
    {
        Nome = nome;
        Genero = genero;
        Preco = preco;
    }

    public string Nome { get; }

    public string Genero { get;  }

    public int Nota{ get; set; }

    public double Preco { get; }
}