/*
 Classe ReprodutorMusical: Responsável por controlar a reprodução de músicas, 
incluindo reprodução, pausa, avanço, retrocesso, controle de volume, etc. 
 
 */

class Player
{
    public Player(Playlist lista, Usuario historico, int volume = 100, bool play = true, bool pause = false, bool forward = false, bool rewind = false)
    {

        Lista = lista;
        Historico = historico;

        Play = play;
        Pause = pause;
        Forward = forward;
        Rewind = rewind;
        Volum = volume;
    }


    private bool tocando;
    private int Volum;
    private int timer;
    private Playlist Lista;
    private Usuario Historico;

    public  bool Play 
    {
        get;
        set;
    }
   
    public bool Pause 
    {
        get => !Play;
        set
        {
            if (value)
            {
                Play = false;
            }
            else
            {
                Play = true;
            }
            
        }
    }

    public bool Forward { get; set; }

    public bool Rewind { get; set; }

    public int Volume 
    {
        get => Volum;
        set
        {
            if(value >= 0 && value <= 100)
            {
                Volum = value;
            }
            else
            {
                Volum = 100;
            }
        } 
    }

   public void IniciaTimer()
   {
        for(int mus = 0; mus < Lista.listaDeMusicas.Count;)
        {
            int inicioTim = Lista.listaDeMusicas[mus].Duracao;

            for(int i = 0; i < inicioTim; i++)
            {
                if (Rewind || Forward)
                {
                    break;
                }

                Thread.Sleep(1000);
                Console.WriteLine($"{i}------------------{inicioTim}");

            }

            if (Forward)
            {
                if (mus == Lista.listaDeMusicas.Count)
                {
                    Forward = false;
                }
                Forward = false;
                mus++;

            }
            else if (Rewind)
            {
                if (mus > 0)
                {

                    mus--;
                    Rewind = false;

                }
                else
                {
                    mus = 0;
                }
                Rewind = false;

            }
            else
            {
                Historico.AdicionarMusicaHistorico(Lista.listaDeMusicas[mus]);
                mus++;
            }


        }
   }
}