class Personagem
{
    private string nome;
    public int Nivel { get; set; }
    public double HPMaxima{ get; set; }
    public double HP { get; set; }
    public Etnia Etnia 
    {
        get => Etnia;
        set 
        {
            Etnia = value;
            HPMaxima += Etnia.BonusHP;
            DanoDeAtaque += Etnia.BonusDado;
            return;
        } 
    } 
    public Classe Classe1 
    {
        get => Classe1;
        set
        {
            Classe1 = value;
            HPMaxima = Classe1.BonusHP;
            Magia = Classe1.BonusMagia;
            Defesa = Classe1.Defesa;
            DanoDeAtaque = Classe1.BonusDano;

        }
    } 
    public double DanoDeAtaque { get; set; }
    public double Magia {  get; set; }
    public double Defesa { get; set; }
    
    List<Item> inventario  = new List<Item> (); 

    public string Nome 
    { 
        get => nome;
        
        set
        {
            if(value == "" || value == null)
            {
                nome = "Sem Nome";
                return;
            }
            else
            {
                nome = value;
            }

        } 
    }

    






}