using System.Diagnostics.CodeAnalysis;

class Album
{
    public Album(string nome, int ano, int duracaoAlbum)
    {
        
        NomeDoAlbum = nome;
        Ano = ano;
        DuracaoTotalDoAlbum = duracaoAlbum;
       

        AdicionarAlbumAoDados();


    }
    public string NomeDoAlbum { get; init; }

    public int Ano { get; }

    public int DuracaoTotalDoAlbum { get; }

    public List<Musica> musicas = new List<Musica>();

    public void AdicionarMusica(Musica musica)
    {

        musica.NomeAlbum = NomeDoAlbum;
        musicas.Add(musica);
        
    }
    private void AdicionarAlbumAoDados()
    {
        Dados.dadosAlbum.Add(this);
    }
    public int DuracaoDasMusicas()
    {
        int tempoTotal = 0;

        foreach (Musica item in musicas)
        {
            tempoTotal += item.Duracao;
        }

        return tempoTotal;
    }

}