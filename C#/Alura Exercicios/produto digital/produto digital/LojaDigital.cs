/*
 Você precisa criar um sistema para uma loja de software. Cada produto digital tem um nome, um preço e detalhes técnicos, como o tamanho do arquivo e o sistema operacional compatível. 
 Esses detalhes técnicos podem variar bastante e, por isso, fazem mais sentido em uma estrutura separada — uma classe só para isso. 
 
 */

 class LojaDigital 
 {
    public string Nome { get; set; }

    public double Preco {  get; set; }

    public InformacaoTec Info { get; set; }

    public LojaDigital(string nome, double preco, InformacaoTec info)
    {
        Nome = nome;

        Preco = preco;

        Info = info;

    }

    public void ExibirProcuto()
    {
        Console.WriteLine($@"Produto: {Nome}
        Preço: {Preco:F2}
        ");
        Info.Exibir();
    }
}