/*
Imagine que você está desenvolvendo um sistema de pedidos para uma loja virtual. 
Toda vez que alguém faz uma compra, o sistema precisa registrar o número do pedido, o nome do cliente e o status atual (por exemplo: "Pendente", "Enviado", "Entregue").
Seu papel é representar esse pedido como uma classe, com os principais atributos e um comportamento: permitir que o status seja atualizado conforme o pedido avança. 
 
 */

class Pedido
{
    private int numPedido;

    private string status;
    public int NumPedido { get => numPedido; }

    public string ClienteNome { get; set; }

    public string Status { get => status; }

    public Pedidos(int numDoPedido, string nomeCliente, string InicialStatus = "Pendente")
    {
        numPedido = numDoPedido;

        ClienteNome = nomeCliente;

        status = InicialStatus;
    }

    public void AtualizarStatus(int modificarStatus)
    {
        switch (modificarStatus)
        {
            case 0:
                status = "Pendente";
                break;
            case 1:
                status = "Enviado";
                break;
            case 2:
                status = "Entregue";
                break;
            default:
                Console.WriteLine(@"Atualize o status do pedido com: 
0 = Pendente
1 = Enviado
2 = Entregue
");
                status = "Pendente";
                break;
        }
    }

    public void Exibir()
    {
        Console.WriteLine(@$"Cliente: {ClienteNome} 
Numero do Pedido: {NumPedido}
Status do pedido: {Status}");

    }
}