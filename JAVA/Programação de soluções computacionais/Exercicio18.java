/*

Create an algorithm to read an integer number, check if the number is in the range between 50 (inclusive) and 100 (inclusive), 
if it is, print "Belongs to the range", otherwise, print "Does not belong to the range


*/

import java.util.Scanner;

public class Exercicio18 {
    public static void main(String[] args){
        Scanner userInput = new Scanner(System.in);

        double num1;
        System.out.println("Write any number. ");
        num1 = userInput.nextDouble();

        if(num1 >= 50 && num1 <= 100){
            System.out.println("Belongs to the range of 50 <= " + num1 + " <= 100");

        }
        else{
            System.out.println("Doesn't belong to the range.");

        }

        userInput.close();

    }
    
}
