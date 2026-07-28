class InformacaoTec 
{
    public int Tamanho { get; set; }

    public string SistemaOpera { get; set; }

    public InformacaoTec(int tamanhoMB, string sistemaO)
    {
        Tamanho = tamanhoMB;
           
        SistemaOpera = sistemaO;

    }

    public void Exibir()
    {
        Console.WriteLine(@$"Tamanho: {Tamanho}MB;
        Sistema Operacional: {SistemaOpera}
        ");
    }
}