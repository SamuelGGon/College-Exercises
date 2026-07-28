class Pedido
{
    private string fazerPedido;

    public string FazerPedido { get; set; }

   

    public Mesa VerificarMesa 
    { 
        get => VerificarMesa;
        set 
        {
            if(VerificarMesa.Disponivel() == true)
            {
                Console.WriteLine("Podem fazer pedido");
            }
        } 
    }

    
   
}