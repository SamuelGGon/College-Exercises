// Classe EstatisticasUsuario: Responsável por coletar e calcular estatísticas relacionadas ao uso da aplicação por parte dos usuários,
// como músicas mais reproduzidas, artistas favoritos, etc.

class Estatistica
{
    Usuario listDeMusicas;
   
    


    public string MusicaMaisEscutada()
    {
        Dictionary<string, int> musicasFrequentes = new Dictionary<string, int>();

        foreach (Musica item in listDeMusicas.historico)
        {
            if (musicasFrequentes.ContainsKey(item.Nome))
            {
                musicasFrequentes[item.Nome] += 1;
            }
            else 
            {
                musicasFrequentes.Add(item.Nome, 1);
                
            }
        }

        var dict1 = musicasFrequentes.OrderByDescending(d => d.Value);

        string musicaFrequente = dict1.ElementAt(0).Key;

        return $"Musica mais escutada {musicaFrequente}";
    }

    public string ArtistaMaisEscutado()
    {
        Dictionary<string, int> artitasFrequentes = new Dictionary<string, int>();

        foreach (Musica item in listDeMusicas.historico)
        {
            if (artitasFrequentes.ContainsKey(item.Artista.NomeArtista))
            {
                artitasFrequentes[item.Artista.NomeArtista] += 1;
            }
            else
            {
                artitasFrequentes.Add(item.Artista.NomeArtista, 1);
            }
        }

        var dict1 = artitasFrequentes.OrderByDescending(d => d.Value);

        string artFrequente = dict1.ElementAt(0).Key;

        return $"O Artista mais escutado(a) {artFrequente}";
    }

    public void TotalDeMusicasOuvidas()
    {
        int total = 0;

        foreach (Musica mus in listDeMusicas.historico)
        {
            total += mus.Duracao;

        }

        if (total / 60 == 0)
        {
            Console.WriteLine($"{total % 60} Segundos");
        }
        else
        {

            if (total / 3600 == 0)
            {
                Console.WriteLine($"{total / 60} Minutos e {total % 60} Segundos");
            }
            else
            {
                Console.WriteLine($"{total / 3600} Hora {(total / 60) % 60} Minutos e {total % 60} Segundos");
            }

        }


    }

    public string GeneroFavorito()
    {
        Dictionary<string, int> genFav = new Dictionary<string, int>();

        foreach (Musica item in listDeMusicas.historico)
        {
            if (genFav.ContainsKey(item.Genero))
            {
                genFav[item.Genero]++;
            }
            else
            {
                genFav.Add(item.Genero, 1);
            }
        }
        var dict1 = genFav.OrderByDescending(d => d.Value);

        string genFrequente = dict1.ElementAt(0).Key;

        return $"O Artista mais escutado(a) {genFrequente}";
    }

    public string AlbumFavorito()
    {
        Dictionary<string, int> albumFav = new Dictionary<string, int>();

        foreach (Musica item  in listDeMusicas.historico)
        {
            if (albumFav.ContainsKey(item.NomeAlbum))
            {
                albumFav[item.NomeAlbum]++;
            }
            else
            {
                albumFav.Add(item.NomeAlbum, 1);
            }
        }

        var dict = albumFav.OrderByDescending(d => d.Value);

        string albumFavori = dict.ElementAt(0).Key;

        return $"O Album Favorito {albumFavori}";
    }
     


}