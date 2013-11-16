package userpininfoextractor;

import java.util.Calendar;
import java.util.Scanner;

public class UserPINInfoExtractor {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        String pin = input.next();

        if (ValidatePin(pin)) {
            System.out.println("Pin is valid!");
            System.out.println(ExtractInfo(pin));
        } else {
            System.out.println("Pin is not valid");
        }

    }

    public static boolean ValidatePin(String pin) {
        if (pin.length() != 10) {
            return false;
        } else {
            int year = Integer.parseInt(pin.substring(0, 2));
            // Validate year ? What is a valid year ?

            int month = Integer.parseInt(pin.substring(2, 4));

            if (month < 1 || month > 12) {
                return false;
            }

            int day = Integer.parseInt(pin.substring(4, 6));

            if (day < 1 || day > 31) {
                return false;
            }
        }

        return true;
    }

    public static String ExtractInfo(String pin) {
        String gender;
        String bitrhDay;
        int age;

        int genderDigit = pin.charAt(pin.length() - 2);
        if (genderDigit % 2 == 0) {
            gender = "male";
        } else {
            gender = "female";
        }

        int year = Integer.parseInt(pin.substring(0, 2));
        
        if (year < 14) {
            year += 2000;
        } else {
            year += 1900;
        }
        
        int month = Integer.parseInt(pin.substring(2, 4));
        int day = Integer.parseInt(pin.substring(4, 6));
        
        bitrhDay = String.format("Year: %d , Month: %d , Day: %d", year, month, day);
        
        age = Calendar.getInstance().get(Calendar.YEAR) - year;
        
        String output = String.format("Gender: %s, Birthday: %s , Age: %d", gender, bitrhDay, age);
        
        return output;
    }
}
