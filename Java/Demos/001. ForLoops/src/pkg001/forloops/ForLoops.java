/* Finding all the even numbers in the interval 20 to 100 */

package pkg001.forloops;

public class ForLoops {

    public static void main(String[] args) {
        
        int numberRangeStart = 20;
        int numberRangeEnd = 100;
        
        for (int i = numberRangeStart; i < numberRangeEnd; i++) {
            
            if (i % 2 == 0) {
                System.out.println(i);
            }
        }
        
    }
    
}
