/*
Make a algorithm that the user input his age and checks user is on legal age.

Faça um algoritmo que verifique a idade do usuario e fale se ele é maior de idade. 

*/

import java.util.Scanner;

public class Exercicio14 {

    public static void main(String[] args){
        Scanner userInput = new Scanner(System.in);

        int age;
        
        System.out.println("Please write your age down: ");
        age = userInput.nextInt();

        if(age >= 18){
            System.out.println("You are on the legal age");

        }
        else{
            System.out.println("Minor");
        }

        userInput.close();
    }
}