using System.ComponentModel.DataAnnotations;

class Mesa
{
    private int numDaMesa;
    
    private int numCadeiras;

    private bool disponivel;

    public int NumDaMesa { get; set; }

    public  int NumCadeira { get; set; }

    public Cardapio Menu { get; set; }

    public bool Disponivel()
    {
        
        if (disponivel == false)
        {
            
            Console.WriteLine("Mesa indisponivel");
            
        }
        else
        {
            
            Console.WriteLine("Mesa disponivel");

            foreach(var item in Menu.Comida)
            {
                Console.WriteLine(item);
            }

        }

        return disponivel;
        
    }

    List<int> mesa = new List<int>();

    public void AddNumCadeiras(int numCadeira)
    {
        mesa.Add(numCadeira);
    }

    public void AddNumDaMesa(int numDaMesa)
    {
        mesa.Add(numDaMesa);
    }


}