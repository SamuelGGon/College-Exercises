/*
Make a program that calculete the average gas consuption in a car
distance in Km and the gas in liters 
 */

import java.util.Scanner;

public class Exercicio03 {
    public static void main(String[] args){
        Scanner userinput = new Scanner(System.in);
        Double dis, gas, average;
        System.out.println("The distance your run car[Km]: ");
        dis = userinput.nextDouble();
        System.out.println("The gas that your car has consuption[Liters]: ");
        gas = userinput.nextDouble();

        average = dis / gas;
        System.out.println("Your cars has average liter consuption of " +  average);
        userinput.close();


    }
    
}


