//Responsável por gerar recomendações personalizadas de músicas com base nos hábitos de audição do usuário.

class Recomendacaos
{
    Usuario listaDeMusicasDele;

    Random rand = new Random();
    private string BuscarMusica(string genero)
    {
        

        List<string> musicasRecomendar = new List<string>();

        foreach (Musica m in Dados.dadosMusica)
        {
            if (m.Genero.Equals(genero))
            {
                musicasRecomendar.Add(m.Nome);
            }
        }

       return musicasRecomendar.ElementAt(rand.Next(0, Dados.dadosMusica.Count));

    }
    public string Recomendar()
    {
        Dictionary<string, int> moda = new Dictionary<string, int>();

        foreach (Musica item in listaDeMusicasDele.historico)
        {
            int quantidade = 0;
            string palavra = "";

            foreach (Musica item2 in listaDeMusicasDele.historico)
            {
                if (item2.Genero.Equals(item.Genero))
                {
                    quantidade++;
                    palavra = item2.Genero;
                }

            }

            if (!moda.ContainsKey(palavra))
            {
                moda.Add(palavra, quantidade);

            }



        }

        var moda1 = moda.OrderByDescending(d => d.Value);

        string generoFrequente = moda1.ElementAt(0).Key;


        return BuscarMusica(generoFrequente);
    }
}