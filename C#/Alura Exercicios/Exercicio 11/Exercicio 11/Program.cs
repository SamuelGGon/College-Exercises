//Criar um programa que simule um sistema de login utilizando um dicionário para armazenar nomes de usuário e senhas.


using System;

namespace aluraExercicio11
{
    class Program
    {
        static void Main(string[] args)
        {

            void AdaptadorDeMensagem(string msg)
            {
                int msgTamanho = msg.Length;
                char asteristico = '#';
                string hasgtag, vazio;
                hasgtag = Convert.ToString(asteristico);
                vazio = "";

                for (int i = 0; i < msgTamanho; i++)
                {
                    vazio += hasgtag;
                }
                Console.WriteLine(vazio);
                Console.WriteLine(msg);
                Console.WriteLine(vazio);

            }


            Dictionary<string, string> userCadastrado = new Dictionary<string, string>();
            userCadastrado.Add("Samuel", "123");

            int escolhaUser;
            string login, senha;

            Console.WriteLine(@"

 ######     ###    ##     ## ##     ##  #######  ##     ## #### ##    ## ##     ##    ###         ######   #######  ##     ##       ## ########  #### ########   #######   #######  ##     ## #### ##    ## ##     ##    ###    
##    ##   ## ##   ###   ### ##     ## ##     ## ##     ##  ##  ###   ## ##     ##   ## ##       ##    ## ##     ## ###   ###      ##  ##     ##  ##  ##     ## ##     ## ##     ## ##     ##  ##  ###   ## ##     ##   ## ##   
##        ##   ##  #### #### ##     ## ##     ## ##     ##  ##  ####  ## ##     ##  ##   ##      ##       ##     ## #### ####     ##   ##     ##  ##  ##     ## ##     ## ##     ## ##     ##  ##  ####  ## ##     ##  ##   ##  
 ######  ##     ## ## ### ## ##     ## ##     ## ##     ##  ##  ## ## ## ######### ##     ##     ##       ##     ## ## ### ##    ##    ########   ##  ########  ##     ## ##     ## ##     ##  ##  ## ## ## ######### ##     ## 
      ## ######### ##     ## ##     ## ##  ## ## ##     ##  ##  ##  #### ##     ## #########     ##       ##     ## ##     ##   ##     ##         ##  ##   ##   ##     ## ##  ## ## ##     ##  ##  ##  #### ##     ## ######### 
##    ## ##     ## ##     ## ##     ## ##    ##  ##     ##  ##  ##   ### ##     ## ##     ## ### ##    ## ##     ## ##     ##  ##      ##         ##  ##    ##  ##     ## ##    ##  ##     ##  ##  ##   ### ##     ## ##     ## 
 ######  ##     ## ##     ##  #######   ##### ##  #######  #### ##    ## ##     ## ##     ## ###  ######   #######  ##     ## ##       ##        #### ##     ##  #######   ##### ##  #######  #### ##    ## ##     ## ##     ## 
            

");





            AdaptadorDeMensagem("Bem - Vindo");

            Console.WriteLine(@"
1. Logar
2. Cadastrar
                
");
            escolhaUser = Convert.ToInt32(Console.ReadLine());

            switch (escolhaUser)
            {
                case 1:

                    AdaptadorDeMensagem("Login");

                    Console.Write("Usuario: ");
                    login = Console.ReadLine();
                    Console.Write("Senha: ");
                    senha = Console.ReadLine();

                    if (userCadastrado.ContainsKey(login) && userCadastrado[login] == senha)
                    {
                        Console.WriteLine("Acesso permitido");
                    }
                    else
                    {
                        if (!userCadastrado.ContainsKey(login))
                        {
                            Console.WriteLine("Usuario não cadastrado");

                        }
                        else if (userCadastrado[login] != senha)
                        {
                            Console.WriteLine("Senha incorreta");
                        }
                    }

                    break;
                case 2:

                    AdaptadorDeMensagem("Cadastro");

                    Console.Write("Escreva seu usuario: ");
                    login = Console.ReadLine();
                    Console.Write("Senha: ");
                    senha = Console.ReadLine();

                    userCadastrado.Add(login, senha);

                    Console.WriteLine("Cadastro feito com sucesso");
                    break;

            }

        }
    }
}