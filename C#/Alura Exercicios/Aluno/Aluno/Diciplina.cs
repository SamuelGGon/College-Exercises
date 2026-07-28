class Diciplina
{
   
    private string alunosMatriculados;

    public string Materia { get; set; }

    public  Aluno AlunosMatriculados { get; set; }


    List<Aluno> listaAluno = new List<Aluno>();

    public void AddDiciplina(Aluno alunoNaDiciplina)
    {
        
        listaAluno.Add(alunoNaDiciplina);

    }

    public void ExibirDiciplinaEAlunos()
    {

        Console.WriteLine(Materia);
        foreach(var indice  in listaAluno)
        {
            Console.WriteLine($"\t{indice}");
        }
    }
}