class Professor
{
    private string nomePro;
    private string diciplinaLecionada;

    public string NomePro { get => nomePro; set => nomePro = value; }

    List<Diciplina> diciplina = new List<Diciplina>();
    public string DiciplinaLecionada { get => diciplinaLecionada; set => diciplinaLecionada = value; }
    

    public void AddDiciplina(Diciplina diciplinaASerADD)
    {
        diciplina.Add(diciplinaASerADD);

    }

    public void ExibirProfEDiciplina()
    {
        Console.WriteLine($"Professor: {NomePro}");
        foreach(var indice in diciplina)
        {
            Console.WriteLine($"\t{indice.ExibirDiciplinaEAlunos}");
        }
        
    }


}
 

