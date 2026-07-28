class Etnia
{
    private string raca; 
    public string Raca 
    {
        get => raca;
        set
        {
            value = value.ToLower();
            switch(value)
            {
                case "humano":
                    BonusHP = 5;
                    BonusDado = 5;

                    break;

                case "elfos":
                    BonusHP = 2;
                    BonusDado = 12;
                    
                    break;

                case "anoes":
                    BonusHP = 20;
                    BonusDado = 2;

                    break;

                case "halflings":
                    BonusHP = 1;
                    BonusDado = 3;

                    break;

                case "gnomos":
                    BonusHP = 4;
                    BonusDado = 8;
                    
                    break;

                case "goblins":
                    BonusHP = 2;
                    BonusDado = 11;
                    
                    break;

                case "orcs":
                    BonusHP = 15;
                    BonusDado = 12;
                    
                    break;

                case "dragonborn":
                    BonusHP = 12;
                    BonusDado = 8;
                    
                    break;

                case "tiefelings":
                    BonusHP = 6;
                    BonusDado = 9;

                    break;

                default:

                    Console.WriteLine("Coloque uma Etinia");
                    BonusDado = 0;
                    BonusHP = 0;
                    return;
                    

            }
            raca = value;
        }
    }
    public double BonusDado { get; set; }
    public double BonusHP { get; set; }




}
