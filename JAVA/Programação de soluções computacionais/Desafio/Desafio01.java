import java.util.Scanner;

public class Desafio01 {
    public static void main(String [] args){
        Scanner userInput = new Scanner(System.in);
        int num;
        boolean pri =  true;

        System.out.println("Write a number");

        num = userInput.nextInt();
        
        

        for(int exit = (int)Math.sqrt(num); exit > 0; exit -= 1){
            if(exit > 1){

                if(num % exit != 0){
                    pri =  true;

                }else{
                    pri = false;
                }
            }


        }

        if(pri == true){
            System.out.printf("Number %d is prime", num);
        }else{
            System.out.printf("Number %d isn't prime", num);

        }



    }
    
}
