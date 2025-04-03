/*

Create an algorithm that reads a number from 1 to 7.
Print the corresponding day of the week;
Assume that 1 corresponds to Sunday.

Crie um algoritmo que leia um número de 1 a 7.
imprima o dia da semana correspondente;
assuma que 1 corresponde ao Domingo

*/






import java.util.Scanner;

public class Exercicio27 {
    public static void main(String[] args) {
        Scanner userInput = new Scanner(System.in);
        int num1;

        System.out.println("Please insert a number within the interval [1 .. 7]");
        num1 = userInput.nextInt();

        switch (num1) {
            case 1:
                System.out.println("Sunday");
                break;
            case 2:
                System.out.println("Monday");
                break;
            case 3:
                System.out.println("Tueday");
                break;
            case 4:
                System.out.println("Wedenesday");
                break;
            case 5:
                System.out.println("Thrusday");
                break;
            case 6:
                System.out.println("Friday");
                break;
            case 7: 
                System.out.println("Saturday");    
                break;
        
            default:
                System.out.println("You insert the wrong interval");
                break;
        }



        userInput.close();

    }
    
}
