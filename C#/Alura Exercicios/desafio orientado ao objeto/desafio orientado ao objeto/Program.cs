class Podcast
{
    List<Episodios> eps = new List<Episodios>();
    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    
    public string Host { get; }

    public string Nome { get; }

    public int TotalEpisodio {  get; private set; }


    public void AdicionarEp(string nome, int duracao, int ordem)
    {
        Episodios ep = new Episodios(nome, duracao, ordem);
        eps.Add(ep);
        
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($" Podcast {Nome}");
        Console.WriteLine($"Host: {Host}");

        for (int i = 0; i < eps.Count; i++)
        {
            Console.WriteLine($"Espisodio {i + 1}");
            Console.WriteLine($"{eps.ElementAt(i)}");


        }
        Console.WriteLine(eps.Count());

    }
}