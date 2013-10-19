
import java.util.Scanner;
import java.util.InputMismatchException;

/**
 * @author Teodor Kurtev
 */
public class FuelCalculatorAdvanced {

    private static Scanner input = new Scanner(System.in);
    private static final int FuleBarier = 10;
    
    private static int startingKilometres;
    private static int endingKilometres;
    private static float spentFuel;

    public static void main(String[] args) {

        try {

            // Data input
            System.out.println("Enter starting Kilometres:");
            setStartingKilometers(input.nextInt());

            System.out.println("Enter endingKilometres:");
            setEndingKilometers(input.nextInt());

            System.out.println("Spent Fuel:");
            setFuelSpent(input.nextFloat());

            // Calulations
            int distance = endingKilometres - startingKilometres;
            float fuelPerKilometre = spentFuel / distance;
            float fulePerHundredKilometres = fuelPerKilometre * 100;

            // Output
            String outputMessage = makeMessage(fulePerHundredKilometres);
            System.out.println(outputMessage);

        } catch (InputMismatchException e) {

            System.out.println("Input was invalid");
            if (e.getMessage() != null) {
                System.out.println(e.getMessage());
            }

        } catch (Exception e) {
            if (e.getMessage() != null) {
                System.out.println(e.getMessage());
            } else {
                System.out.println(e);
            }
        }
    }

    private static void setStartingKilometers(int value) {
        startingKilometres = value;

        if (startingKilometres < 0) {
            throw new InputMismatchException("Starting kilometers must not be negative!");
        }
    }

    private static void setEndingKilometers(int value) {
        endingKilometres = value;

        if (endingKilometres < 0) {
            throw new InputMismatchException("Ending kilometers must not be negative!");
        }
    }

    private static void setFuelSpent(float value) {
        spentFuel = value;

        if (spentFuel < 0) {
            throw new InputMismatchException("Fuel spent must not be negative!");
        }
    }

    private static String makeMessage(float fuelPerHunderedKiloms) {
        String message = String.format("Your car burns %f liters of fuel per 100 kilometers. ", fuelPerHunderedKiloms);

        if (fuelPerHunderedKiloms < FuleBarier) {

            message += "Congratulations!";

        } else if (fuelPerHunderedKiloms > FuleBarier) {

            message += "You have a problem!";

        } else {

            message += "On the spot!";
        }

        return message;
    }
}
