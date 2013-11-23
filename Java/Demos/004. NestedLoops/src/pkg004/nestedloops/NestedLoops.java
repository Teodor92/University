/* Print a Right Triangle on the console */

package pkg004.nestedloops;

public class NestedLoops {

    public static void main(String[] args) {
        
        for (int i = 1; i < 10; i++) {
            for (int j = 0; j < i; j++) {
                System.out.print(j);
            }
            
            System.out.println();
        }
        
    }
    
}
