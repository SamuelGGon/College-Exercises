class Item
{
    private string nome;

    private int quantidadeDOItem;

    private double peso;

    private double valor;
    public string Nome 
    {
        get => nome; 
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("Ponha um nome ao item");
            }
        } 
    }

    public int QuantidadeDoItem 
    {
        get => quantidadeDOItem;
        set
        {
            if(value == 0 || value == null)
            {
                Console.WriteLine("Não pode ter zero, pois não existira o item");
                return;
            }
                
            quantidadeDOItem = value;
            return;
        }
    }

    public double Peso 
    {
        get => peso;
        set
        {
            if (value == 0 || value == null)
            {
                Console.WriteLine("Não pode ter pese zero, pois não existira o item");
                return;
            }

            peso = value;
            return;
        }
    }

    public double Valor 
    { 
        get => valor;
        set
        {
            if(value < 0)
            {
                Console.WriteLine("Não pode num negativo");
            }
        }
    }



}