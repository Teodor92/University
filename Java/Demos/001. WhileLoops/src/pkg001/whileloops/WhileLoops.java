/* Find all the numbers that are NOT divisible by 3 in the range 0 to 100 */

package pkg001.whileloops;

public class WhileLoops {

    public static void main(String[] args) {

        int number = 0;
        
        while (number < 100) {            
            number++;
            
            if (number % 3 == 0) {
                continue;
            }
            
            System.out.println(number);
        }

    }

}
