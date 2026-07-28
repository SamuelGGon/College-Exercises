using System;
using System.Security.Cryptography.X509Certificates;

namespace testes
{
    class testes
    {
        public static void Main(string[] args)
        {


            Album al1 = new Album("Pintinho", 1970, 380);

            Musica mu1 = new Musica("piu", 10, new GeneroMusical("samba rock", "rock porra"), new ArtistaMusical("Ferrugem", "Comerdor de cus"));

            //mu1.NomeAlbum


            al1.AdicionarMusica(mu1);

            Console.WriteLine(mu1.NomeAlbum);




           
               
            

         
        }
    }
}
