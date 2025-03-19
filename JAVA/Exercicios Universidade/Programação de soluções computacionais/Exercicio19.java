/*

Create an algorithm that reads a person's height and gender, calculates, and displays their ideal weight.


Faça um algoritmo que leia a altura e o sexo de uma pessoa: calcule e mostre seu peso ideal.

imc = weight / height²




*/

import java.util.Scanner;

public class Exercicio19 {
    
    public static void main(String[] args){
        Scanner userInput = new Scanner(System.in);
        double height, weight;
        String sex;
        char sex1;

        System.out.println("Verify if you are on ideal weight");
        System.out.println("What is your sex ? [M / F]");
        sex = userInput.nextLine();
        System.out.println("What is yout height in meter ? ");
        height =  userInput.nextDouble();
        sex = sex.toUpperCase();
        sex1 =  sex.charAt(0);


        
        if(sex1 == 'M'){
            weight = 24 * Math.pow(height, 2);
            System.out.printf("Your ideal weight is %.2f%n", weight);


        }
        else if (sex1 == 'F') {
            weight = 22 * Math.pow(height, 2);
            System.out.printf("Your ideal weight is %.2f%n",weight);
            
        }
        
        
        userInput.close();
    }
}
