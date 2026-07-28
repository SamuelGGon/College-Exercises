class Biblioteca
{
    List<Usuario> usuariosDaBiblioteca = new List<Usuario>();

    List<Livro> acervo = new List<Livro>();

    List<Emprestimo> emprestimos = new List<Emprestimo>();

    public void AdicionarUsuario(Usuario usuarioNovo)
    {
        usuariosDaBiblioteca.Add(usuarioNovo);

    }
    
    public void VerAcervo()
    {
        foreach(Livro item in acervo)
        {
            Console.Write($"Titulo: {item.Titulo} Genero: {item.Genero} ISBN {item.ISBN} Autor {item.Autor} Disponibilidade {item.Disponibilidade}\n");
        }

    }

    public void EmprestarLivro(Usuario usuario, Livro livro)
    {

        if(livro.Disponibilidade == false)
        {
            Console.WriteLine("Livro Emprestado");
        }
        else
        {
            Emprestimo usuarioComLivro = new Emprestimo();

            usuarioComLivro.usuarioQuePegouOLivro = usuario;

            usuarioComLivro.livroEmprestado = livro;

            usuarioComLivro.IndisponibilizaLivros();

            emprestimos.Add(usuarioComLivro);

        }


    }

    public void Devolucao(Emprestimo devolver)
    {
        emprestimos.Remove(devolver);

        devolver.livroEmprestado.Disponibilidade = true;

    }
    
    

}