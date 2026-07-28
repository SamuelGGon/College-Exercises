//Classe AvaliacaoMusica: Representa uma avaliação feita por um usuário em relação a uma música, contendo informações como a pontuação e o comentário.


class DadosAvaliacaoMusical
{
    public string Comentario { get; set; }

    public int Nota { get; set; }
}



class AvalicaoMusical
{

    AvalicaoMusical(string comentario, Musica mus, int nota)
    {
        Avaliar(mus, nota, comentario);
    }

    Dictionary<Musica, List<DadosAvaliacaoMusical>> avaliacao = new Dictionary<Musica, List<DadosAvaliacaoMusical>>();

    public void Avaliar(Musica nome, int nota, string comentario)
    {
        DadosAvaliacaoMusical ficha = new DadosAvaliacaoMusical
        {
            Nota = nota,
            Comentario = comentario

        };

        if (avaliacao.ContainsKey(nome) == false)
        {
            avaliacao.Add(nome, new List<DadosAvaliacaoMusical>());
            avaliacao[nome].Add(ficha);
        }
        else
        {
            avaliacao[nome].Add(ficha);
        }
        
    }

}