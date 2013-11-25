/* Finding all the even numbers in the interval 20 to 100 */

package pkg001.forloops;

public class ForLoops {

    public static void main(String[] args) {
       
//        int number = 20;
//        
//        while (number < 100) {            
//            number++;
//            
//            if (number % 2 == 0) {
//                System.out.println("" + number);
//            }
//        }
        
        
        
        for (int i = 20; i < 100; i++) {
            
            if (i % 2 == 0) {
                System.out.println(i);
            }
        }
        
    }
    
}
