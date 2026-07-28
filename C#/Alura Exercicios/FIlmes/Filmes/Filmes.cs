/*
Imagine que você está criando um sistema de recomendação para uma plataforma de filmes. Cada filme tem um título e uma classificação indicativa. 
Para garantir que as pessoas vejam apenas conteúdos apropriados para sua idade, o sistema deve verificar se a pessoa pode assistir ao filme com base na idade informada.

Crie uma classe chamada Filme que tenha:

Propriedades públicas Titulo e ClassificacaoEtaria (int).
Um método chamado PodeAssistir(int idadeUsuario) que retorna true se a idade for maior ou igual à classificação etária, e false caso contrário.
Um método ExibirResultado(int idadeUsuario) que exiba uma mensagem amigável informando se o usuário pode ou não assistir ao filme.
 */

public class Filmes
{
    private int classificacao;
    public string Titulo{ get; set; }

    public int Classificacao 
    { 
        get => classificacao;
        set
        {
            if (value >= 0 && value <= 18)
            {
                classificacao = value;

            }
            else
            {
                Console.WriteLine("Erro, classificacão fora do escopo em 0 a 18");
            }
        }

    }

    public void ClassificacaoEtaria(int idade)
    {
        if (idade >= classificacao || classificacao == 0)
        {
            Console.WriteLine($"Pode assistir ao filme: {Titulo}");
        }
        else { Console.WriteLine($"Infelizmente não pode assistir ao filme {Titulo}"); }
    }
}