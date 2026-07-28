/*
Você recebeu a missão de automatizar o sistema de estoque de uma papelaria. 
Cada item precisa registrar seu nome e a quantidade atual em estoque. 
O sistema deve permitir retirar itens, mas somente se houver quantidade suficiente disponível. 
Caso contrário, deve exibir uma mensagem informando a falha.

Crie uma classe chamada Produto com:

Propriedade pública Nome.
Campo privado quantidadeEstoque.
Um construtor que receba o nome e a quantidade inicial.
Um método público Retirar(int quantidade) que:
Reduz a quantidade apenas se houver estoque suficiente.
Exiba uma mensagem indicando o sucesso ou a falha da operação.
Um método ExibirEstoque() para mostrar a quantidade atual.
 */

public class Produto
{
    private int quantidadeEstoque;

    public string Nome { get; set; }

    public Produto(string nome, int quantidade)
    {
        Nome = nome;

        quantidadeEstoque = quantidade;

    }

    public void Retirar(int quantidade)
    {
        if(quantidadeEstoque >= quantidade && quantidadeEstoque != 0)
        {
            quantidadeEstoque -= quantidade;
            Console.WriteLine($"Sucesso. Sobraram {quantidadeEstoque}");
        }
        else
        {
            Console.WriteLine("Não foram retirados, pois a quantidade fornecida excede o estoque");
        }
    }

    public void ExibirEstoque()
    {
        Console.WriteLine(@$"Nome: {Nome}
Estoque: {quantidadeEstoque}
");
    }

}