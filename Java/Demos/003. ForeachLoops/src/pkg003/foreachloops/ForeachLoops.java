/* Print all the numbers int the array, that are greater that 15 */
package pkg003.foreachloops;

public class ForeachLoops {

    public static void main(String[] args) {
        int[] randomNumbers = {1, 132, 33, 23, 11, 15, 1233, 22};
        
        int borderNumber = 15;

        for (int number : randomNumbers) {
            if (number > borderNumber) {
                System.out.println(number);
            }
        }
    }

}
