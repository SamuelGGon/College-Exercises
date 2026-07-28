/*

Create an algorithm that prints half of each number from 10 to 20.

Faça um algoritmo que imprima metade de cada numero de 10 a 20.

*/



public class Exercicio36 {
    public static void main(String[]args ){
        double numStart, valor;
        numStart = 10;
        
        while (numStart <= 20) {
            valor = numStart / 2;
            
            System.out.printf("The half of the %.2f is %.2f\n", numStart, valor);
            numStart ++;

            
        }

        
    }
    
}
