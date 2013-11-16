import java.util.Scanner;

/**
 *
 * @author Teodor Kurtev
 */
public class FuelCalculator {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        // Data input
        System.out.println("Enter starting Kilometres:");
        int startingKilometres = input.nextInt();

        System.out.println("Enter endingKilometres:");
        int endingKilometres = input.nextInt();

        System.out.println("Spent Fuel:");
        float spentFuel = input.nextFloat();

        // Calulations
        int distance = endingKilometres - startingKilometres;
        float fuelPerKilometre = spentFuel / distance;
        float fulePerHundredKilometres = fuelPerKilometre * 100;

        // Output
        if (fulePerHundredKilometres < 100) {

            System.out.printf("Your car burns %f liters of fuel per 100 kilometers. Congratulations! \n", fulePerHundredKilometres);

        } else if (fulePerHundredKilometres > 100) {

            System.out.printf("Your car burns %f liters of fuel per 100 kilometers. You have a problem! \n", fulePerHundredKilometres);

        } else {
            
            System.out.printf("Your car burns %f liters of fuel per 100 kilometers. On the spot! \n", fulePerHundredKilometres);
        }

    }
}
