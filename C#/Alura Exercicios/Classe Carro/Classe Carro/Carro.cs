class Carro
{
    public double Acelerar { get; set; }

    private int ano;
    private string anoDescricao;

    public double Frear {  get; set; }
    public string Modelo { get; set; }

    public int Ano 
    {
        get => ano;
        set
        {
            
            if (value >= 1960 && value <= 2023)
            {
                ano = value;
                return;
            }
            else
            {
                anoDescricao = "Ano Invalido, só entra carro de  1960 à 2023";
                
                return;  
            }
            
        }
    }

    public string Marca { get; set; }

    public string DescricaoDetalheda 
    {
        get
        {
            if (ano >= 1960 && ano <= 2023)
            {
                return $"\nMarca: {Marca}\nModelo: {Modelo}\nAno: {ano}";
            }
            else
            {
                return $"\nMarca: {Marca}\nModelo: {Modelo}\nAno: {anoDescricao}";
            }
            
            
        } 
    }
    





    public double Acelerando(double numDaAceleracao, int tempoDeAceleracao)
    {
        
        

        for (int i = 0; i < tempoDeAceleracao; i++)
        {
            numDaAceleracao *= 2;
            Console.WriteLine($"Acelerando {numDaAceleracao}");
        }

        return numDaAceleracao;

        
    }

    public void Freando(double aceleracaoAtual, int tempoDeFrear)
    {
        for(int i = 0; i < tempoDeFrear; i++)
        {
            aceleracaoAtual *= 0.5;
            Console.WriteLine($"Freando {aceleracaoAtual}");

            if (aceleracaoAtual <= 0)
            {
                break;
            }
        }

    }

    public void Buzina()
    {
        Console.WriteLine("BI BI");
    }


}