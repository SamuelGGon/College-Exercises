using System.Runtime.CompilerServices;

class Musica
{

    public Musica(string nome, int duracao, GeneroMusical genero, ArtistaMusical artista)
    {
        Nome = nome;
        Duracao = duracao;
        Genero = genero.NomeGenero;
        Artista = artista;
       
        AdicionarMusicaAoDados();
        
    }  

    public string NomeAlbum { get; set; }

    public string Nome {  get; }

    public int Duracao { get;  }

    public string Genero { get; }

    public string Letra { get; set; }
    public ArtistaMusical Artista{ get; } 
   
    private void AdicionarMusicaAoDados()
    {
        Dados.dadosMusica.Add(this);
    }


}