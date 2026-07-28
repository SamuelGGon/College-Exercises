/*
Create an algorithm to find the largest number among three integers.
The algorithm should:
Read three integers;
If they are all equal, print: "The numbers are equal";
Otherwise, print the largest of the three numbers.


Faça um algoritmo para encontrar o maior número entre 3 números inteiros.
O algoritmo deve ler três inteiros;
se forem todos iguais, imprimir: “os números são iguais”;
caso contrário, imprimir o maior dos 3 números.

*/






import java.util.Scanner;

public class Exercicio23 {
    public static void main(String[] args) {
        double num1, num2, num3, bigger, smaller;
        Scanner userInput = new Scanner(System.in);

        System.out.println("Write a number: ");
        num1 = userInput.nextDouble();
        System.out.println("Write another number: ");
        num2 = userInput.nextDouble();
        System.out.println("Write a more number: ");
        num3 = userInput.nextDouble();
        bigger = smaller = 0;

        if(num1 > num2 && num2 < num3){
            smaller = num2;
            if(num1 > num3){
                bigger = num1;

            }
            else{
                bigger = num3;
            }
            
            System.out.println("The biggest number inputed is " + bigger + ", and the smaller is " + smaller);
            
        }
        if(num2 > num1 && num1 < num3){
            smaller = num1;
            if(num2 > num3){
                bigger = num2;

            }
            else{
                bigger = num3;
            }
            
            System.out.println("The biggest number inputed is " + bigger + ", and the smaller is " + smaller);
            
        }
        if(num1 > num3 && num3 < num2){
            smaller = num3;
            if(num1 > num2){
                bigger = num1;

            }
            else{
                bigger = num2;
            }
            System.out.println("The biggest number inputed is " + bigger + ", and the smaller is " + smaller);

        }
        
        else if (num1 == num2 && num2 == num3 ){
            System.out.println("all number are equal");

        }
       

                  

        userInput.close();
    }
    
}
