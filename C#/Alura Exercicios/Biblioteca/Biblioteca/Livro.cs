class Livro
{
    private string titulo;
    public string Titulo 
    {
        get => titulo;
        set 
        {
            if (value == "" || value == null)
            {
                Console.WriteLine("titulo não pode ser vazio");
            }
            else
            {
                titulo = value;
            }
        } 
    }

    public  string Genero { get; set; }
    public long ISBN { get; set; }
    public string Autor {  get; set; }
    public bool Disponibilidade { get; set; }
    

    

    
}

    




