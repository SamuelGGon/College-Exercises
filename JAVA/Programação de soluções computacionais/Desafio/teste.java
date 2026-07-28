public class teste {
    public static void main(String[] args){

        char array[] = new char[3];
        boolean vazio = false;

        array[0] = 'a';
        array[1] = 0;
        array[2] = 'b';

        
        for(int exit = 0; exit <= array.length; exit+= 1){

            if (array[exit] != 0) {
                vazio = true;

                System.out.printf("O elemento está vazio %b", vazio );

                
            }
            System.out.println(array[exit]);

        }
        
    }
    
}
