/*

Create an algorithm that displays on the screen the squares of the integers from 15 to 100.  
Example:  
The square of 15 is 225  
The square of 16 is 256  
. . .  
The square of 100 is 10000  

Faça um algoritmo que apresente na tela os quadrados dos 	números inteiros de 15 a 100.
Exemplo:
O quadrado de 15 é 225
O quadrado de 16 é 256
. . .
O quadrado de 100 é 10000


*/


public class Exercicio42 {
    public static void main(String[] args){
        int num;
        double sqr;
        num = 15;

        for(; num <= 100; num += 1){
            sqr = Math.pow(num, 2);
            System.out.println(sqr);
            
        }

    }
}
