/*
Make a algorithm that reads a integer number
if the number is bigger than 20, calcule and print half of it.

Faça um algoritimo que lei um numero inteiro
se o numero for maior que 20, calcule e imprima a metade dele.

*/
import java.util.Scanner;

public class Exercicio09 {
    public static void main(String[] args){
        Scanner userInput = new Scanner(System.in);

        int number;

        System.out.println("Please insert a number");
        number = userInput.nextInt();

        if(number >= 20){
            double numberD;

            numberD = number / 2;
            System.err.println("The half of " + number + " = " + numberD);

        }
        else{

            System.err.println("The number isn't bigger then 20.");
        }



        userInput.close();
    }
    
}
