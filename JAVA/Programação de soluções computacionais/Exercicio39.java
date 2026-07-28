/*

The BMI (Body Mass Index) is a measure of a person's degree of obesity.
Create an algorithm that reads the height and weight of 10 people.
Calculate the BMI of each person and check how many people have a BMI between 18.5 and 24.9, which is considered a normal weight.

O IMC (índice de Massa Corporal) é uma medida do grau de obesidade 	de uma pessoa.
Faça um algoritmo que leia a altura e o peso de 10 pessoas.
Calcular o IMC de cada pessoa e verificar quantas pessoas estão com o IMC entre 18,5 e 24,9 que é considerado sem obesidade.

*/

import java.util.Scanner;

public class Exercicio39 {
    public static void main(String[] args){
        double weight, height, count, howManyPeople, imc;

        Scanner userInput = new Scanner(System.in);
        count = 0;
        howManyPeople = 0;
        
        while (count <= 10) {
            System.out.println("Please insert your height [Meter]: ");
            height = userInput.nextDouble();
            System.out.println("Please insert your weight [Kg]: ");
            weight = userInput.nextDouble();

            imc = weight / (Math.pow(height, 2));

            if (imc >= 18.5 && imc <= 24.9) {
                howManyPeople ++;
                
            }else{

            }
            count ++;            
        }
        System.out.printf("There is %.2f many people with ideal weight", howManyPeople);
        userInput.close();
    }
    
}
