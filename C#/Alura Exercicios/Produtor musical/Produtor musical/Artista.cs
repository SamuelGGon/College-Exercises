/*
 
Classe Artista: Representa um artista musical, contendo informações como nome, biografia, lista de álbuns, etc. 
 */
class ArtistaMusical
{
    public ArtistaMusical(string nome, string bio)
    {
        NomeArtista = nome;
        Biografia = bio;

        AdicionarArtistaAoDados();
    }
    
    public string NomeArtista { get; }

    public string Biografia { get; }

    List<Album> Albums = new List<Album>();


    public void ExebirArtista(string NomeArtista)
    {
        
        
            Console.WriteLine($"{NomeArtista}");
            Console.WriteLine($"\t {Biografia}");
            Console.WriteLine("Alguns albuns do artista");

            for(int i = 0; i < Albums.Count ; i++)
            {
                if (i == 3)
                {
                    break;
                }
                Console.WriteLine(Albums[i].NomeDoAlbum);
            }
        
    }

    private void AdicionarArtistaAoDados()
    {
        Dados.dadosArtista.Add(this);
    }

}

