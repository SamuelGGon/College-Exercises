public class Episodios
{
    List<string> convidado = new List<string>();
    public Episodios(string titulo, int duracao, int ordem)
    {
        Titulo = titulo;
        Duracao = duracao;
        Ordem = ordem;

    }
    public int Duracao { get; }

    public string Resumo 
    { 
        get => $"{Ordem}. {Titulo} ({Duracao} min) - " +
            $"{string.Join(", ", convidado)}"; 
    }


    public string Titulo { get; }

    public int Ordem { get;} 
    public string Convidados { get; private set; }


    public void AdicionarConvidados(string nomeConvidado)
    {
        convidado.Add(nomeConvidado);
    }
}