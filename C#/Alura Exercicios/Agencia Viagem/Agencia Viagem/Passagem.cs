/*
Você está criando um sistema de emissão de passagens para uma agência de viagens. Cada passagem precisa obrigatoriamente conter o nome do passageiro e o destino, definidos no momento da criação.

Crie uma classe chamada Passagem que tenha:

Uma propriedade pública Passageiro.
Uma propriedade pública Destino.
Um construtor que obrigue o preenchimento dessas informações na criação do objeto.
Depois, crie uma instância da classe e exiba os dados da passagem. 

 */

class Passagem
{
    public Passagem(string nome, string destino)
    {
        Nome = nome;

        Destino = destino;
    }

    private string Nome { get; }

    private string Destino { get; }

    public void exibir()
    {
        Console.WriteLine(@$"
Detalhes da Passagem:

Nome: {Nome};

Destino: {Destino};

");
    }
}