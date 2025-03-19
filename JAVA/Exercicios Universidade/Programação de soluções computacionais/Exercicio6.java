/*
Ask the user to input the temperature in Celsius and the program output in Fahrenheit

Peça ao usuario colocar a temperatura em celcius e o programa da em Fahrenheit
 */


import java.util.Scanner;

public class Exercicio6 {
    public static void main(String[] args){
        Scanner userInput = new Scanner(System.in);
        double tempC, tempF;

        System.out.println("Please insert a Celsius temperature: ");

        tempC = userInput.nextDouble();

        tempF = (9*tempC) / 5 + 32;

        System.out.println("The temperature in ºC " + tempC + " to Fahrenheit is " + tempF);
        
        userInput.close();



    }
}
