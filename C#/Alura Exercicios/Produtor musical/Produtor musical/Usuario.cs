//Classe Usuario: Representa um usuário da aplicação, com informações como nome,
//e-mail, senha, histórico de reprodução, playlists criadas, etc.

using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

class Usuario
{
    public Usuario(string senha, string nome, string email)
    {
        Senha = senha;
        Nome = nome;
        Email = email;
        VerificarEmail(Email);
    }
    //fazer o tratamento dos email e criar e ver historico de reprodu.

    public List<Musica> historico = new List<Musica>();
    private string Senha { get; }

    public string Nome { get; }

    public string Email { get; }

    public Playlist PlaylistUser { get; set; }

    private void VerificarEmail(string email)
    {

        if (email == null)
        {
            throw new Exception("Email está vazio");
        }
        if (!email.Contains("@"))
        {
            throw new Exception("Não é um email valido");
        }
    }
       
    public void AdicionarMusicaHistorico(Musica nome)
    {
        historico.Add(nome);
    }

}