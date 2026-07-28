/*
Desenvolver uma classe que representa um catálogo de jogos, 
com uma lista de Jogos e métodos para manipular essa lista, 
bem como um construtor que faça sua inicialização. 
 */


class CatalogoJogos
{
    
   List<Jogo> jogos = new List<Jogo>();

    public void AdicionarJogo(string nome, string genero, double preco)
    {
        Jogo novoJogo = new Jogo(nome, genero, preco);

        jogos.Add(novoJogo);
        
    }

}