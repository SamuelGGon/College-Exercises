/*

Create an algorithm that receives a swimmer's age and prints their category: according to the rules:
Category:	Age
infantilA	5 - 7 years
infantilB	8 - 10 years
juvenilA	11 - 13 years
juvenilB	14 - 17 years
Senior	18 years or more

Faça um algoritmo que receba a idade de um nadador e imprima a sua categoria seguindo as regras:

*/

import java.util.Scanner;

public class Exercicio24 {
    public static void main(String[] args){
        int age;
        Scanner userInput = new Scanner(System.in);

        System.out.println("Hello swimmer, please insert your age: ");
        age = userInput.nextInt();

        if(age >= 5 && age <= 7){
            System.out.println("You are on the category: Infantil A");
        }
        else if(age >= 8 && age <= 10){
            System.out.println("You are on the category: Infantil B");
            
        }
        else if(age >= 11 && age <= 13){
            System.out.println("You are on the category: Juvenil A");
            
        }
        else if(age >= 14 && age <= 17){
            System.out.println("You are on the category: Juvenil B");
            
        }
        else if(age >= 18){
            System.out.println("You are on the category: Senior");

        }


        userInput.close();

    }
    
}
