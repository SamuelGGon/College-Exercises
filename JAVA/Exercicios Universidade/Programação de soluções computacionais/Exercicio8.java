/*
Make a program that calculete the fabrication and distribution tax on the car's price: Fabrication 15% and distribution 30%

Faça um programa que calcule o imposto de fabricação e distribuição no preço do carro: fabricação 15% e distribuição 30% 
*/


import java.util.Scanner;

public class Exercicio8 {
    public static void main(String[] args){
        Scanner userInput = new Scanner(System.in);
        double carPrice;

        System.out.print("Car's price $");
        carPrice = userInput.nextDouble();
        
        carPrice = carPrice * 1.45;

        System.out.println("The new car's price with taxation is $" + carPrice);

        userInput.close();
    }
    
}
