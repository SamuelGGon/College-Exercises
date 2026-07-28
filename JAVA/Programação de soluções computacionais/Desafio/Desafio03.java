import java.util.Scanner;

public class Desafio03 {
    public static void main(String[] args){

        int stop, sum;
        Scanner userInput = new Scanner(System.in);

        
        sum = 0;
        
        while (true) {

            System.out.println("Please writer a number: [-1 to exit]");

            stop = userInput.nextInt();

            if (stop == -1) {
                break;
            }else{
                sum += stop;
            }


            System.out.printf("variavel sum %d \n", sum);
            System.out.printf("variavel stop %d \n", stop);
    
        }

        System.out.println(sum);
    }
    
}
