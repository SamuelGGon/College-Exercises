/*
Você está criando um sistema para agendamento de consultas em uma clínica. Toda consulta envolve o nome do paciente, o nome do médico e a data marcada. 
É comum que consultas sejam reagendadas — e seu sistema precisa permitir isso.

Você deve criar uma classe que represente uma consulta com os dados essenciais e um método para reagendar, mantendo o controle da data atualizada.
 */

class Consulta
{
    private string nomePaciente;

    private string nomeMedico;

    private DateTime dataAtual;

    private bool regendado = false;
    public string NomePaciente 
    { 
        get => nomePaciente;
        set 
        { 
            value = nomePaciente;
        }   
    }

    public string NomeMedico
    {
        get => nomeMedico;
        set
        {
            value = nomeMedico;
        }
    }
    public int Mes 
    { 
        get; 
        set
        {
            if (value < 0 || value > 12)
            {
                Console.WriteLine("Os meses só vão de 1 a 12");
            }
        } 
    }
    public int Dia 
    { 
        get; 
        set
        {
            if(value < 1 || value > 31)
            {
                Console.WriteLine("Dias só vão de 1 a 31, dependendo do mês");
            }
        }
    }

    public Consulta(string paciente, string medico, int dia, int mes)
    {
        nomePaciente = paciente;
        nomeMedico = medico;


        int ano = DateTime.Now.Year;


        DateTime dataConsulta = new DateTime(ano, mes, dia);

        dataAtual = dataConsulta;

        

    }

    public void MudarData(int dia, int mes)
    {
        int ano = DateTime.Now.Year;

        DateTime novaData = new DateTime(ano, mes, dia);
        dataAtual = novaData;

        regendado = true;
    }

    public void Exibir()
    {
        Console.WriteLine($@"Paciente: {NomePaciente} terá consulta com Médico: {NomeMedico} na data: {dataAtual}");
    }
}