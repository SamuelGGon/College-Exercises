/*

Create an algorithm that reads the period in which a student studies:  
M - Morning;  
V - Afternoon;  
N - Night.

Faça um algoritmo que leia o período em que um aluno estuda:


*/

import java.util.Scanner;

public class Exercicio29 {
    public static void main(String[] args){

        String day;
        char day1;
        System.out.println("Which period do you Study ? ");
        System.out.println("M - Morning");
        System.out.println("A - Afternoon");
        System.out.println("N - Night");

        Scanner userInput =  new Scanner(System.in);

        day = userInput.nextLine();
        day = day.toUpperCase();
        day1 = day.charAt(0);
        switch (day1) {
            case 'M':
                System.out.println("Good Morning");
                break;
            case 'A':
                System.out.println("Good Afternoon");
                break;
            case 'N':
                System.out.println("Good night");
                break;
        
            default:
                System.out.println("Invalid input");
                break;
        }

        userInput.close();
    }
    
}
