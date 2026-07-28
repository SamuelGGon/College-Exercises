/*
 Você foi contratado(a) para desenvolver um sistema de operações bancárias. Cada conta precisa ter um número e um saldo inicial. 
E, deve existir um método para realizar depósitos, recebendo o valor a ser depositado como parâmetro.

Crie uma classe chamada ContaBancaria que tenha:

Uma propriedade pública NumeroConta.
Uma propriedade pública Saldo.
Um método Depositar(double valor) que adicione o valor ao saldo existente.
Depois, crie uma instância da classe, realize um depósito e exiba o saldo atualizado. 
 
 */

class ContaBancaria
{
    public ContaBancaria(string conta, decimal saldo)
    {
        Conta = conta;
        Saldo = saldo;
    }
    public string Conta { get; }

    public decimal Saldo { get; set; }

    public void Depositar(decimal valor)
    {
        Saldo += valor;
    }

    public void detalhes()
    {
        Console.WriteLine($@"Conta: {Conta}
Saldo: {Saldo}
    
");
    }

}
