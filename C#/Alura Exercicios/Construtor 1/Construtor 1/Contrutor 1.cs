// Criar um construtor para a classe Titular, que inicialize todas suas propriedades:

class Titular
{
    public Titular(string nome, string cpf, string endereco)
    {
        Nome = nome;
        Cpf = cpf;
        Endereco = endereco;
    }

    public string Nome { get; }
    public string Cpf { get;  }
    public string Endereco { get; }
}