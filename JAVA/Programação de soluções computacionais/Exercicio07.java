/*
Make a program that calculates the triangle area.

Faça uma programa que calcule a area do triângulo.
*/

import java.util.Scanner;

public class Exercicio07 {
    public static void main(String[] args){
        double area, base, height;
        Scanner userInput = new Scanner(System.in);

        System.out.println("Please insert the triangle's base: ");
        base = userInput.nextDouble();

        System.out.println("Please insert the triangle's height: ");
        height = userInput.nextDouble();
        
        area = base * height / 2;

        System.out.println("the triangle's area is (" + area +")");


        


        userInput.close();

    }
    
}
