class Classe
{
    private string classes;
    public double BonusHP { get; set; }

    public double BonusMagia { get; set; }

    public double Defesa {  get; set; }

    public double BonusDano { get; set; }

    public string Classes
    {
        get => classes; 
        set
        {
            value = value.ToLower();

            switch (value)
            {
                case "guerreiro":
                    BonusHP = 20;
                    BonusMagia = 0;
                    Defesa = 15;
                    BonusDano = 10;
                    break;

                case "mago":
                    BonusHP = 10;
                    BonusMagia = 30;
                    Defesa = 2;
                    BonusDano = 20;
                    break;

                case "arqueiro":
                    BonusHP = 5;
                    BonusMagia = 5;
                    Defesa = 5;
                    BonusDano = 15;
                    break;

                case "paladino":
                    BonusHP = 15;
                    BonusMagia = 10;
                    Defesa = 12;
                    BonusDano = 5;
                    break;

                case "assassino":
                    BonusHP = 0;
                    BonusMagia = 0;
                    Defesa = 3;
                    BonusDano = 25;
                    break;

                default:
                    Console.WriteLine("Escolha uma Classe");
                    break;

            }
            classes = value;

        }
    }





}