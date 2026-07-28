class TitularDaConta
{
    private int conta;
    private int agencia;
    public ContaDebanco Titular { get; set; }
    public int Conta { get => conta; set => conta = value;}
    public int Agencia { get => agencia; set => agencia = value; }

    public void ContaDetalhada()
    {
        Console.Write($"ID da conta: {Titular.NumIndicador}" +
            $"\nTitular: {Titular.Titular}\nAgencia: {agencia}\nConta: {conta}" +
            $"\nSaldo: {Titular.Saldo}");
    }


}