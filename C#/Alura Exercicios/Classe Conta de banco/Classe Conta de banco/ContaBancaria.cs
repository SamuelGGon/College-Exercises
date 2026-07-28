class ContaDebanco
{
    private string senha;
    public int NumIndicador {  get; set; }
    public string Titular {  get; set; }
    public decimal Saldo {  get; set; }
    private string Senha { set; get; }

    public void ExibirContas()
    {
        Console.WriteLine($"Conta: {Titular}");
        Console.WriteLine($"Saldo: R${Saldo}");
    }
}