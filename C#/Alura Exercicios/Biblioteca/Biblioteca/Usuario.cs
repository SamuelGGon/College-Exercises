class Usuario
{
    private string nome;
    public string Nome 
    {
        get
        {
            return nome;
        }
        set
        {
            if (value == "" || value == null)
            {
                Console.WriteLine("Não pode dizer o nome vazio");
            }
            else
            {
                nome = value;
            }
        } 

    }

    public string Carteirinha { get; set; }

    List<Livro>livrosEmprestado = new List<Livro>();



}