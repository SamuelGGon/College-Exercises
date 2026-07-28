public class Livro
{
    public string titulo { get; set; }

    public string autor { get; set; }

    public void Exibicao()
    {
        Console.WriteLine(@$"
Livro: {titulo}
Autor: {autor}
");
    }

}