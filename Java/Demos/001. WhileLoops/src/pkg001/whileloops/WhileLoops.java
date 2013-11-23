/* Find all the numbers that are NOT divisible by 3 in the range 0 to 100 */

package pkg001.whileloops;

public class WhileLoops {

    public static void main(String[] args) {

        int intervalStart = 0;
        int intervalEnd = 0;

        while (true) {
            intervalStart++;

            if (intervalStart % 3 == 0) {
                continue;
            }

            System.out.println(intervalStart);

            if (intervalStart == intervalEnd) {
                break;
            }
        }

    }

}
