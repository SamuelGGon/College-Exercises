class Emprestimo
{
    private DateTime dateDeEmprestimo = DateTime.Now;
    public DateTime DataDeEmprestimo { get; set; }
    public Livro livroEmprestado { get; set; }
    public Usuario usuarioQuePegouOLivro { get; set; }

    public DateTime DataDeDevolucao(int diasDeEprestimo) 
    { 
        return dateDeEmprestimo.AddDays(diasDeEprestimo);
        
    }

    public void IndisponibilizaLivros()
    {
        livroEmprestado.Disponibilidade = false;
    }
    
}