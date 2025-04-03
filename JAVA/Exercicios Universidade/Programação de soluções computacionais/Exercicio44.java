/*

Create an algorithm that receives the age and height of 10 people:  
– Calculate and display the average height of those over 50 years old.

Faça um algoritmo que receba a idade e a altura de 10 pessoas:
– calcule e mostre a média das alturas daquelas com mais de 50 anos.


*/

import java.util.Scanner;

public class Exercicio44 {
    public static void main(String[] args) {
        Scanner userInput = new Scanner(System.in);

        double averageFifty, height;
        int exit, age, howManyFifty;

        exit = 0;
        averageFifty = 0;
        howManyFifty = 0;

        for(; exit <= 9; exit += 1){
            System.out.println("How old are you ?");
            age = userInput.nextInt();

            System.out.println("Please insert your height [meters]:");
            height = userInput.nextDouble();

            if (age > 50){
                averageFifty += height;
                howManyFifty += 1;

            }else{

            }

            
        }
        averageFifty = averageFifty / howManyFifty;

        System.out.println(averageFifty);

        userInput.close();
        
    }
    
}
