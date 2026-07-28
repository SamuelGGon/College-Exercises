class Restaurante
{
    private Mesa mesa;

    private Cardapio cardapio;

    private bool reservaMesa;

    public bool Reservar
    {
        get => reservaMesa;
        set 
        {
            if (value == false)
            {
                reservaMesa = value;
                if (mesa.Disponivel() == false)
                {
                    Console.WriteLine("Mesa não reservada");
                    
                    
                }
            }
            else
            {
                reservaMesa = value;
                Console.WriteLine("Mesa Reserva");
                
            }
        } 
    }
    
    
}