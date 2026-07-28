class Playlist
{
    public Playlist(string nomeDaPlaylist, Musica nomeDaMusica)
    {
        Nome = nomeDaPlaylist;
        AdicionarMusicas(nomeDaMusica);
        AdicionarPlaylistAoDados();
        
    }

    public string Nome { get; }


    public List<Musica> listaDeMusicas = new List<Musica>();

    public void AdicionarMusicas(Musica musica)
    {
        listaDeMusicas.Add(musica);
    }

    private void AdicionarPlaylistAoDados()
    {
        Dados.dadosPlayLis.Add(this);
    }

    
}   