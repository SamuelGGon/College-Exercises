/*
 * comerdarios
 *
 */
import java.util.Scanner;

public class exercicio1 {
    public static void main(String[] args) {
        Scanner entrada = new Scanner(System.in);
        System.out.println("Escreva algo que está sentido agora: ");
        
        String algumaCoisa = entrada.nextLine();

        System.out.println("Por que você escreveu, " + algumaCoisa + " ?");

        entrada.close(); //Server para liberar espaço na memoria ram, apos o uso de seu programa tudo que for executado a cima ao encontrar esse close, terminou.
        System.out.print("alguma coisa \n Roberto");
        
    }
}
