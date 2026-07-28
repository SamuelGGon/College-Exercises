class Cardapio
{
    private string comida;
   

    List<string> cardapio = new List<string>();

    public string Comida { get; set; }

   

    public void AdcionarComidaAoMenu(string comida)
    {

        cardapio.Add(comida);

    }


}