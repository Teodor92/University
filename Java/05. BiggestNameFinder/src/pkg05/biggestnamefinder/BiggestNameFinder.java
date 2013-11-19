package pkg05.biggestnamefinder;

import java.util.Scanner;

public class BiggestNameFinder {

    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);
        System.out.println("Enter the number of number of employees. It must be between 2 and 10.");

        int numberOfEmployees = input.nextInt();

        // Input validation
        while (numberOfEmployees < 2 || numberOfEmployees > 10) {

            System.out.println("Invalid! Try again:");
            numberOfEmployees = input.nextInt();
        }

        String[] names = new String[numberOfEmployees];

        for (int i = 0; i < names.length; i++) {
            System.out.printf("Enter the name of employee number %d.\n", i + 1);
            names[i] = input.next();
        }

        String bestname = ""; 
        // Or String bestname = names[0] , it will have no difference in this case.

        for(int i = 0; i < names.length; i++) {
            if (names[i].length() > bestname.length()) {
                bestname = names[i];
            }
        }

        System.out.printf("The longest name is: %s . \n", bestname);
    }

}
