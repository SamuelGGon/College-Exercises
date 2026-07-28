//Classe Busca: Responsável por realizar pesquisas de músicas, artistas, álbuns ou playlists com base em critérios fornecidos pelo usuário.
class Busca
{
    public Busca(string procura)
    {
        Buscar(procura);
    }



    public static void Buscar(string procuraUser)
    {
        string uper = procuraUser.ToUpper();


        int controlador = 0;

        foreach (Musica item in Dados.dadosMusica)
        {
            if (controlador == 3)
            {
                break;
            }  
            
            if (item.Nome.ToUpper().Contains(uper))
            {
                controlador += 1;

                Console.WriteLine(item.Nome);
                if(item.Letra != null)
                {
                    Console.WriteLine(item.Letra);
                }
                else
                {
                    Console.WriteLine("estamos trabalhando pra colocar a letra da musica");
                }
            }
            else if (item.Artista.NomeArtista.ToUpper().Contains(uper))
            {
                controlador += 1;

                Console.WriteLine(item.Artista.NomeArtista);
            }


        }
            controlador = 0;
            
        foreach(Album album in Dados.dadosAlbum)
        {
            if (controlador == 3)
            {
                break;
            }

            if (album.NomeDoAlbum.ToUpper().Contains(uper))
            {
                controlador += 1;
                Console.WriteLine(album.NomeDoAlbum);
            }

        }


        foreach(Playlist playlist in Dados.dadosPlayLis)
        {
            if (controlador == 3)
            {
                break;
            }

            if (playlist.Nome.ToUpper().Contains(uper))
            {
                controlador += 1;
                Console.WriteLine(playlist.Nome);
            }

        }
        



    }



}