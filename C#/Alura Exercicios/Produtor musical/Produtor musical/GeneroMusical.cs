/*
Classe GeneroMusical: Representa um gênero musical, 
contendo informações como nome, descrição, lista de artistas ou músicas associadas, etc. 
 */

using System.Runtime.ExceptionServices;

class GeneroMusical
{
    public GeneroMusical(string nome, string descricao) 
    {
        NomeGenero = nome;
        Descricao = descricao;
    }
    public string NomeGenero { get;  }

    public string Descricao { get;  }

    List<Musica> musicaList = new List<Musica>();

    Dictionary<string, string>  genEDisc = new Dictionary<string, string>();

 

    public void AdicionarAoDicionario()
    {
        genEDisc.Add(NomeGenero, Descricao);
    }
    
    public void ExibirDescricaoGenero(string Genero)
    {
        if (genEDisc.ContainsKey(Genero))
        {
            Console.WriteLine($"{Genero}:");
            Console.WriteLine($"\tgenEDisc[Genero]");
        }
        else
        {
            Console.WriteLine("Genero ainda não definido");
        }

       
        
        
    }
    public void ExibirMusicasAssociadasAoGenero()
    {
        Console.WriteLine($"Musicas com esse genero");
        foreach (Musica item in musicaList)
        {
            if (item.Genero == NomeGenero)
            {
                Console.WriteLine($"{item}\n");

            }
        }
    }

}