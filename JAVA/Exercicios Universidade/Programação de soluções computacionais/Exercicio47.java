/*

Create an algorithm that receives the age, height, and weight of 10 people, then calculates and displays:  
a) The number of people older than 50 years.  
b) The average height of people aged between 10 and 20 years.  
c) The percentage of people weighing less than 40 kilograms.

Faça um algoritmo que receba a idade, a altura e o peso de 10 pessoas, calcule e mostre:
a) A quantidade de pessoas maiores de 50 anos.
b) A média das alturas das pessoas com idade entre 10 e 20 anos.
c) A porcentagem de pessoas com peso inferior a 40 quilos.


*/

import java.util.Scanner;

public class Exercicio47 {
    public static void main(String[]args ){

        int exit, fifyTotal, age;
        double average, percentage, height, weight, heightTotal, heightSum, weightForty;
        exit = fifyTotal = 0;
        average = percentage = heightTotal =  weightForty = heightSum = 0;

        Scanner userInput = new Scanner(System.in);

        for(; exit <= 9; exit += 1){
            System.out.println("Please insert your age: ");
            age = userInput.nextInt();
            System.out.println("Please insert your height[Meters]: ");
            height = userInput.nextDouble();
            System.out.println("Please insert your weight[Kg]: ");
            weight = userInput.nextDouble();

            if (age > 50) {
                fifyTotal += 1;
                
            }if (age >= 10 && age <= 20) {
                heightTotal += 1;
                heightSum += height;
                
            }if (weight < 40) {
                weightForty += 1;
                
            }        
            
            
        }

        if (heightTotal != 0){

            average = heightSum / heightTotal;
        }else{

            average = 0;
        }

        percentage = (weightForty / 10) * 100;

        System.out.printf("Average's height between 10  and 20 year old is %.2f", average);
        System.out.printf("There is %d many people over 50 ", fifyTotal);
        System.out.printf("The percentage of people under 40Kg is %.2f", percentage);

        userInput.close();
    }
    
}
