/*

Create an algorithm that prints the multiplication table of 5.

Faça um algoritmo que imprima a tabuada do 5.


*/


public class Exercicio37 {
    public static void main(String[]args ){
        int count, value;
        
        count = 0;
        do{
            value = count * 5;
            System.out.printf("The multiplicantion 5 x %d = %d \n", count, value);
            count ++;

        }while(count <= 10);
    }
    
}
