import java.util.ArrayList;
import java.util.Scanner;

public class Exercicio53 {
    public static void main(String[] args){

        Scanner userInput =  new Scanner(System.in);
        ArrayList<Double> nota = new ArrayList<Double>();
        double nota1, nota2, media;
        nota2 = 0;

        System.out.println("Vamos calcular a media !");

        while (true) {
            System.out.println("Escreva uma nota:  [-1 sai]");
            nota1 = userInput.nextDouble();

            if(nota1 == -1){
                
                break;
            }

            nota.add(nota1);

                                    
        }

        for(int exit = 0; exit < nota.size(); exit += 1){
            
            nota2 += nota.get(exit);
            

        }

        media = nota2 / nota.size();

        System.out.printf("Sua media: %.2f", media);
        
        userInput.close();
    }

    
}
